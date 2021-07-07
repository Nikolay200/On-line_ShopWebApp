using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Helpers;
using System.Collections.Generic;

namespace OnlineShopWebApp.Views.Shared.ViewComponents.CartViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private readonly ICartsStorage cartStorage;

        public CartViewComponent(ICartsStorage cartsStorage)
        {
            this.cartStorage = cartsStorage;
        } 
        public IViewComponentResult Invoke()
        {
            var cart = cartStorage.TryGetByUserId(Constants.UserId);

            var cartViewModel = Mapping.ToCartViewModel(cart);            
            var productCounts = cartViewModel?.Amount ?? 0;
            return View("Cart", productCounts);
        }
        
    }
}
