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

        public async Task<IActionResult> Profile()
        {
            // Get the currently authenticated user
            var user = await _userManager.GetUserAsync(User);
            
            if (user != null)
            {
                // Retrieve the user's data from the database
                // You can access properties like user.UserName, user.Email, etc.
                // and pass them to the view as needed
                // For example:
                var userProfile = new ProfileViewModel
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    StreetAdress = user.StreetAdress,
                    PostalCode = user.PostalCode,
                    City = user.City,
                };
                var roles = await _userManager.GetRolesAsync(user);
                var role = roles.FirstOrDefault();

                userProfile.Role = role;

                return View(userProfile);
            }

            return RedirectToAction("Login", "Account"); // Redirect to login if user is not authenticated
        }

        public IActionResult UsersList()
        {
            // Check if the current user has the "Admin" role
            if (User.IsInRole("Admin"))
            {
                // Retrieve all users from the database
                var users = _userManager.Users.ToList();

                // Create a list to hold user and role information
                var userList = new List<ProfileViewModel>();

                foreach (var user in users)
                {
                    // Retrieve the roles of each user
                    var role = _userManager.GetRolesAsync(user).Result.FirstOrDefault();

                    // Create a view model object to store user and role information
                    var userProfile = new ProfileViewModel
                    {
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

                // Pass the list of users and roles to the view
                return View(userList);
            }

            // If the current user doesn't have the "Admin" role, return an unauthorized response
            return Unauthorized();
        }
    }
}
