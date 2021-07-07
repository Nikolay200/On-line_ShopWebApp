using OnlineShop.Db.Models;
using System;

namespace OnlineShop.Db
{
    public interface ICartsStorage
    {
        void Add(Product product, string userId);
        Cart TryGetByUserId(string userId);
        void DecreaseAmount(Guid productId, string userId);
        void Clear(string userId);
    }
}