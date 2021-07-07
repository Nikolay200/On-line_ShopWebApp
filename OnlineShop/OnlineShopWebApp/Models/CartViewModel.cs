using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopWebApp
{
    public class CartViewModel
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }// Пользователь, создающий корзину
        public List<CartItemViewModel> Items { get; set; }

        public decimal Cost
        {
            get
            {
                return Items?.Sum(x => x.Cost) ?? 0;//Вычисляет итоговую сумму заказа (Сумма всех CartItem) 
            }
        }
        public decimal Amount
        {
            get
            {
                return Items?.Sum(x => x.Amount) ?? 0;//Вычисляет итоговую сумму продуктов
            }
        }
    }
}