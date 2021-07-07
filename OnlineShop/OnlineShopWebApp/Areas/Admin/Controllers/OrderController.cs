using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Areas.Admin.Models;
using OnlineShopWebApp.Helpers;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
    {        
        private readonly IOrdersStorage ordersStorage;
      
        public OrderController(IOrdersStorage ordersStorage)
        {           
            this.ordersStorage = ordersStorage;            
        }

        public IActionResult Index()
        {
            var orders = ordersStorage.GetAll();
            return View(orders.Select(x => Mapping.ToOrderViewModel(x)).ToList());            
        }
        public IActionResult Detail(Guid orderId)
        {
            var order = ordersStorage.TryGetById(orderId);
            return View(Mapping.ToOrderViewModel(order));
        }

        public IActionResult UpdateOrderStatus(Guid orderId, OrderStatusViewModel status)
        {
            ordersStorage.UpdateStatus(orderId,(OrderStatus)(int)status);
            return RedirectToAction(nameof(Index));
        }      
    }
}
