using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShopWebApp.Helpers;
using System;
using System.Collections.Generic;


namespace OnlineShopWebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductsStorage productStorage;
        private readonly ICartsStorage cartsStorage;

        public CartController(IProductsStorage productStorage, ICartsStorage cartsStorage)
        {
            this.productStorage = productStorage;
            this.cartsStorage = cartsStorage;
        }       

        public IActionResult Index()
        {
            var cart = cartsStorage.TryGetByUserId(Constants.UserId);
            return View(Mapping.ToCartViewModel(cart));
        }
        public IActionResult Add(Guid productId)
        {
            var product = productStorage.TryGetById(productId);
            cartsStorage.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }

        public IActionResult DecreaseAmount(Guid productId)
        {           
            cartsStorage.DecreaseAmount(productId, Constants.UserId);
            return RedirectToAction("Index");
        }

        public IActionResult Clear()
        {
            cartsStorage.Clear(Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
