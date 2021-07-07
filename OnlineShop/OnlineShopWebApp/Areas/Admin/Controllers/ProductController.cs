using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Helpers;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IProductsStorage productStorage;
        
        public ProductController(IProductsStorage productStorage)
        {
            this.productStorage = productStorage;            
        }

        public IActionResult Index()
        {
            var products = productStorage.GetAll();           
            return View(Mapping.ToProductViewModels(products));
        }
        
        public IActionResult Remove(Guid productId)
        {
            var product = productStorage.TryGetById(productId);
            var products = productStorage.GetAll();
            products.Remove(product);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(Guid productId)
        {
            var product = productStorage.TryGetById(productId);
            return View(product);
        }


        [HttpPost]
        public IActionResult Edit(ProductViewModel product)
        {
                                  
            if (ModelState.IsValid)
            {
                return View(product);
            }
            var productDb = new Product
            {
                Name = product.Name,
                Cost = product.Cost,
                Description = product.Description,
                ImagePath = product.ImagePath
            };
            productStorage.Update(productDb);
            return RedirectToAction(nameof(Edit));
        }
        public IActionResult Add()
        {
            var products = productStorage.GetAll();
            return View(products);
        }

        [HttpPost]
        public IActionResult Add(ProductViewModel product)
        {
                                  
            if (ModelState.IsValid)
            {
                return View(product);
            }

            var productDb = new Product
            {
                Name = product.Name,
                Cost = product.Cost,
                Description = product.Description,
                ImagePath = product.ImagePath
            };
            var existingProducts = productStorage.GetAll();
            existingProducts.Add(productDb);
            return RedirectToAction(nameof(Add));
        }
    }
}
