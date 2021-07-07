using System;
using System.Collections.Generic;

namespace OnlineShop.Db.Models
{
    public class CartItem //Информация о товаре в корзине
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public Cart Cart { get; set; }
               
    }
}