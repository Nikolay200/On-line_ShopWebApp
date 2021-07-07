using System;
using System.Collections.Generic;

namespace OnlineShop.Db.Models
{
    public class Product
    {
        
        public Guid Id { get; set; }
       

        public string Name { get; set; }
        
        public decimal Cost { get; set; }
        
        public string Description { get; set; }
        
        public string ImagePath { get; set; }

        public List<CartItem> CartItems { get; set; }


        public Product(string name, decimal cost, string description, string imagePath) : this()
        {
            Id = Guid.NewGuid();
            Name = name;
            Cost = cost;
            Description = description;
            ImagePath = imagePath;            
        }

        public Product()
        {
            CartItems = new List<CartItem>();
        }

    }
}

