using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Db
{
    public class ComparingDbStorage : IComparingStorage
    {
        private readonly DatabaseContext databaseContext;

        public ComparingDbStorage(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }


        public void Add(string userId, Product product)
        {
            var existingProduct = databaseContext.ComparingProducts.FirstOrDefault(x => x.UserId == userId && x.Product.Id == product.Id);
            if (existingProduct == null)
            {
                databaseContext.ComparingProducts.Add(new ComparingProduct { Product = product, UserId = userId });
                databaseContext.SaveChanges();
            }
        }
        public void Clear(string userId)
        {
            var userComparingProducts = databaseContext.ComparingProducts.Where(u => u.UserId == userId).ToList();
            databaseContext.ComparingProducts.RemoveRange(userComparingProducts);
            databaseContext.SaveChanges();
        }

        public List<Product> GetAll(string userId)
        {
            return databaseContext.ComparingProducts.Where(u => u.UserId == userId).Include(x => x.Product).Select(x => x.Product).ToList();
        }

        public void Remove(string userId, Guid productId)
        {
            var removingComparing = databaseContext.ComparingProducts.FirstOrDefault(u => u.UserId == userId && u.Product.Id == productId);
            databaseContext.ComparingProducts.Remove(removingComparing);
            databaseContext.SaveChanges();
        }
    }
}
