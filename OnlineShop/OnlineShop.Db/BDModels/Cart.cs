using System;
using System.Collections.Generic;

namespace OnlineShop.Db.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }// Пользователь, создающий корзину
        public List<CartItem> Items { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Cart()
        {
            Items = new List<CartItem>();
        }
       
    }
}