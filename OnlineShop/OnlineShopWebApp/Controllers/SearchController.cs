using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShopWebApp.Models;
using System.Collections.Generic;

namespace OnlineShopWebApp.Controllers
{
    public class SearchController : Controller
    {
        private readonly IProductsStorage productStorage;
        
        public SearchController(IProductsStorage productStorage)
        {
            this.productStorage = productStorage;
            
        }

        public IActionResult Search()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Search(string searchString)
        //{
            
        //    var detectedProducts = productStorage.GetAll();
        //    var coincidences = new List<ProductViewModel>();
        //    foreach (var product in detectedProducts)
        //    {
        //        if (product.Name.ToLower().Contains(searchString.ToLower()))
        //        {
        //            coincidences.Add(product);
        //        }
        //    }
        //    return View(coincidences);
        //}
    }
}
