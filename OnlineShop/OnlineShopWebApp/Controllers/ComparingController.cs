using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShopWebApp.Helpers;
using System;

namespace OnlineShopWebApp.Controllers
{
    public class ComparingController : Controller
    {
        private readonly IProductsStorage productStorage;
        private readonly IComparingStorage comparingStorage;
        public ComparingController(IProductsStorage productStorage, IComparingStorage comparingStorage)
        {
            this.productStorage = productStorage;
            this.comparingStorage = comparingStorage;
        }

        public IActionResult Index()
        {
            var comparingProduct = comparingStorage.GetAll(Constants.UserId);
            return View(Mapping.ToProductViewModels(comparingProduct));
        }
        public IActionResult Add(Guid id)
        {
            var existingProduct = productStorage.TryGetById(id);
            comparingStorage.Add(Constants.UserId, existingProduct);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(Guid id)
        {
            var existingProduct = productStorage.TryGetById(id);
            comparingStorage.Remove(Constants.UserId, id);
            return RedirectToAction(nameof(Index));
        }
    }
}
