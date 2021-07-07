using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;

namespace OnlineShop.Db
{
    public interface IProductsStorage
    {
        List<Product> GetAll();
        Product TryGetById(Guid id);
        void Update(Product product);
    }
}