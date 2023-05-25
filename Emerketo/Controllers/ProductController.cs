using Emerketo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emerketo_webapp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult AllProducts()
        {
            ViewBag.Display = "All of our Plants";
            // The argument passed to the return View() sets the Model to be used for the view
            return View(_productRepository.AllProducts);
        }
        public IActionResult Details(int id) 
        {
            var product = _productRepository.GetProductById(id);
            
            if (product == null) 
                return NotFound();

            return View(product);
        }
    }
}
