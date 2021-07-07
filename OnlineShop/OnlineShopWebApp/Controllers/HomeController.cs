using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShopWebApp.Helpers;

namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProductsStorage productStorage;
        public HomeController(IProductsStorage productStorage)
        {
            this.productStorage = productStorage;
        }

        public IActionResult Index()
        {
            
            var products = productStorage.GetAll();                        
            return View(Mapping.ToProductViewModels(products));
        }
       
    }
}

