using Emerketo.Models;
using Emerketo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Emerketo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                HeroDisplay = _productRepository.FeaturedProducts.FirstOrDefault(),
                NewProducts = _productRepository.NewProducts.Take(4),
                PopularProducts = _productRepository.PopularProducts.Take(4),
                FeaturedProducts = _productRepository.FeaturedProducts.Skip(1).Take(3),
            };

            return View(homeViewModel);
        }
    }
}
