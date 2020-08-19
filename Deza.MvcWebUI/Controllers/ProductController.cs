using Deza.Business.Abstract;
using Deza.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Deza.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAll();

            return View(products.Data);
        }

        [HttpGet]
        public IActionResult Detail(int productId)
        {
            var product = _productService.GetProduct(productId);

            return View(product.Data);
        }

        [HttpGet]
        public IActionResult Save()
        {
            var result = _productService.InitializeProduct();

            return View(result.Data);
        }

        [HttpPost]
        public IActionResult Save(ProductSaveVM product)
        {
            var products = _productService.AddProduct(product);

            return View(products);
        }

        public IActionResult GetReports()
        {
            var products = _productService.GetAll();

            return View(products.Data);
        }


    }
}
