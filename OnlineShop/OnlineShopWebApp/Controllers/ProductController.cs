using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using System;
using System.Collections.Generic;


namespace OnlineShopWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductsStorage productStorage;

        public ProductController(IProductsStorage productStorage)
        {
            this.productStorage = productStorage;
        }       
        public IActionResult Index(Guid id)

        {
            var product = productStorage.TryGetById(id);
            return View(product);
        }


        //public string Index(Guid id)
        //{
        //    var product = productStorage.TryGetById(id);

        //    if (product == null)
        //    {
        //        return $"Продукта с номером {id} нет в каталоге! Выберите другой номер.";
        //    }

        //    return $"{product}\n{product.Description}";

        //}

    }
}
