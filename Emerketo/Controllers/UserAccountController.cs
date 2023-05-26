using Emerketo.Areas.Identity.Data;
using Emerketo.Models;
using Emerketo.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Emerketo.Controllers
{
    public class UserAccountController : Controller
    {
        private readonly UserManager<EmerketoUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IProductRepository _productRepository;

        public UserAccountController(UserManager<EmerketoUser> userManager, RoleManager<IdentityRole> roleManager, IProductRepository productRepository)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _productRepository = productRepository;
        }

        public async Task<IActionResult> Profile(string username)
        {
			// Get the currently authenticated user
			var user = await _userManager.FindByNameAsync(username);

            if (user != null)
            {
                // Retrieve the user's data from the database
                // You can access properties like user.UserName, user.Email, etc.
                // and pass them to the view as needed
                // For example:
                var userProfile = new ProfileViewModel
                {
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    StreetAdress = user.StreetAdress,
                    PostalCode = user.PostalCode,
                    City = user.City,
                };
                // get users role
                var roles = await _userManager.GetRolesAsync(user);
                var role = roles.FirstOrDefault();

                userProfile.Role = role;

				// get roles existing in db

				var rolesInDb = _roleManager.Roles.Select(r => r.Name).ToList();

                userProfile.RolesInDb = rolesInDb;

				return View(userProfile);
            }
            
            return RedirectToAction("Login", "Account"); // Redirect to login if user is not authenticated
        }
        [HttpPost]
        public async Task<IActionResult> Profile(ProfileViewModel profile)
        {
            var user = await _userManager.FindByNameAsync(profile.UserName);

            if (user != null)
            {
                // Update the user's role based on the selected value in the profile
                await _userManager.AddToRoleAsync(user, profile.Role);

                // Other profile update operations if needed

                // Redirect to a success or profile updated page
                return RedirectToAction("ProfileUpdated");
            }
            else
            {
                // User not found in the database, handle the error or show a message
                // Redirect to an error page or display an error message in the view
                return RedirectToAction("Error");
            }
        }

        public IActionResult UsersList()
        {
            // Check if the current user has the "Admin" role
            if (User.IsInRole("Admin"))
            {                
                // Retrieve all users
                var users = _userManager.Users.ToList();

                var userList = new List<ProfileViewModel>();

                foreach (var user in users)
                {
                    // Retrieve the roles of each user
                    var role = _userManager.GetRolesAsync(user).Result.FirstOrDefault();

                    // Create a view model object to store user and role information
                    var userProfile = new ProfileViewModel
                    {
                        UserName = user.UserName,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        StreetAdress = user.StreetAdress,
                        PostalCode = user.PostalCode,
                        City = user.City,
                        Role = role
                    };

                    // Add the user and role information to the list
                    userList.Add(userProfile);
                }
				// retrieve list of roles
				var roles = _roleManager.Roles.Select(r => r.Name).ToList();

                UsersListViewModel usersListViewModel = new UsersListViewModel
                {
                    Users = userList,
                    Roles = roles
                };


				// Pass the list of users and roles to the view
				return View(usersListViewModel);
            }

            // If the current user doesn't have the "Admin" role, return an unauthorized response
            return Unauthorized();
        }
    }
}
