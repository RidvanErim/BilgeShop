using BilgeShop.Business.Services;
using BilgeShop.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BilgeShop.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productServices;
        public ProductController(IProductService productServices )
        {
            _productServices = productServices;
        }
        

        [Route("{productName}-{id}")]
        public IActionResult Detail(int id)
        {
         var product= _productServices.GetProductById(id);
            var viewModel = new ProductDetailViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                UnitInStock = product.UnitInStock,
                UnitPrice = product.UnitPrice,
                ImagePath = product.ImagePath,
            };

           
            return View(viewModel);
        }
    }
}
