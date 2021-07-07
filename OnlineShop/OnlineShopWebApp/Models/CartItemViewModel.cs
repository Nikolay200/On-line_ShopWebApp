using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;

namespace OnlineShopWebApp
{
    public class CartItemViewModel //Информация о товаре в корзине
    {
        public Guid Id { get; set; }
        public ProductViewModel Product { get; set; }
        public int Amount { get; set; }
        
        public List<ProductViewModel> Products { get; set; }
        public decimal Cost
        {
            get
            {
                return Product.Cost * Amount;//Цена товара умножается на количество этого товара
            }
        }
    }
}