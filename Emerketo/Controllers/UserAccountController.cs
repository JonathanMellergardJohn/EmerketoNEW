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
    }
}
