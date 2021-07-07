using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Helpers;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartsStorage cartsStorage;
        private readonly IOrdersStorage ordersStorage;
        public OrderController(ICartsStorage cartsStorage, IOrdersStorage ordersStorage)
        {
            this.cartsStorage = cartsStorage;
            this.ordersStorage = ordersStorage;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Buy(UserDeliveryInfoViewModel userViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View("Index", userViewModel);
            }
            var existingCart = cartsStorage.TryGetByUserId(Constants.UserId);
           
            var order = new Order
            {
                User = Mapping.ToUser(userViewModel),
                Items = existingCart.Items
            };
            ordersStorage.Add(order);
            cartsStorage.Clear(Constants.UserId);
            return View();
        }
    }
}
