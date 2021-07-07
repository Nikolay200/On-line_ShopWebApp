using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Db
{
    public class FavoritesDbStorage : IFavoritesStorage
    {
        private readonly DatabaseContext databaseContext;

        public FavoritesDbStorage(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        
        public void Add(string userId, Product product)
        {
            var existingProduct = databaseContext.FavoriteProducts.FirstOrDefault(x => x.UserId == userId && x.Product.Id == product.Id);
            if(existingProduct == null)
            {
                databaseContext.FavoriteProducts.Add(new FavoriteProduct { Product = product, UserId = userId });
                databaseContext.SaveChanges();
            }            
        }
        public void Clear(string userId)
        {
            var userFavoriteProducts = databaseContext.FavoriteProducts.Where(u => u.UserId == userId).ToList();
            databaseContext.FavoriteProducts.RemoveRange(userFavoriteProducts);
            databaseContext.SaveChanges();
        }

        public List<Product> GetAll(string userId)
        {
            return databaseContext.FavoriteProducts.Where(u => u.UserId == userId).Include(x => x.Product).Select(x => x.Product).ToList();
        }

        public void Remove(string userId, Guid productId)
        {
            var removingFavorite = databaseContext.FavoriteProducts.FirstOrDefault(u => u.UserId == userId && u.Product.Id == productId);
            databaseContext.FavoriteProducts.Remove(removingFavorite);
            databaseContext.SaveChanges();
        }
    }
}
