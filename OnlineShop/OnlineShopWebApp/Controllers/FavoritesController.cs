using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShopWebApp.Helpers;
using System;

namespace OnlineShopWebApp.Controllers
{
    public class FavoritesController : Controller
    {

        private readonly IProductsStorage productStorage;
        private readonly IFavoritesStorage favoritesStorage;
        public FavoritesController(IProductsStorage productStorage, IFavoritesStorage favoritesStorage)
        {
            this.productStorage = productStorage;
            this.favoritesStorage = favoritesStorage;
        }

        public IActionResult Index()
        {
            var favoriteProduct = favoritesStorage.GetAll(Constants.UserId);
            return View(Mapping.ToProductViewModels(favoriteProduct));
        }
        public IActionResult Add(Guid id)
        {
            var existingProduct = productStorage.TryGetById(id);
            favoritesStorage.Add(Constants.UserId, existingProduct);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(Guid id)
        {
            var existingProduct = productStorage.TryGetById(id);
            favoritesStorage.Remove(Constants.UserId, id);
            return RedirectToAction(nameof(Index));
        }
    }
}
