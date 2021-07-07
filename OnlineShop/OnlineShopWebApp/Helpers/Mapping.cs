using OnlineShop.Db.BDModels;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;

namespace OnlineShopWebApp.Helpers
{
    public static class Mapping
    {
        public static List<ProductViewModel> ToProductViewModels(List<Product> products)
        {
            
            var productsViewModels = new List<ProductViewModel>();
            foreach (var product in products)
            {               
                productsViewModels.Add(ToProductViewModel(product));
            }
            return productsViewModels;
        }

        public static ProductViewModel ToProductViewModel(Product product)
        {            
                return new ProductViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Cost = product.Cost,
                    Description = product.Description,
                    ImagePath = product.ImagePath
                };  
        }
        public static CartViewModel ToCartViewModel(Cart cart)
        {
            if(cart == null)
            {
                return null;
            }
            return new CartViewModel
            {
                Id = cart.Id,
                UserId = cart.UserId,
                Items = ToCartItemViewModels(cart.Items)
            };
        }

        public static UserDeliveryInfo ToUser(UserDeliveryInfoViewModel user)
        {
            return new UserDeliveryInfo
            {
                LastName = user.LastName,
                FirstName = user.FirstName,
                PatronymicName = user.PatronymicName,
                Phone = user.Phone,
                Town = user.Town,
                Street = user.Street,
                House = user.House,
                Flat = user.Flat,
                Email = user.Email,
                Index = user.Index
            };
        }

        public static List<CartItemViewModel> ToCartItemViewModels(List<CartItem> cartDbItems)
        {
            var cartItems = new List<CartItemViewModel>();
            foreach (var cartDbItem in cartDbItems)
            {
                var cartItem = new CartItemViewModel
                {
                    Id = cartDbItem.Id,
                    Amount = cartDbItem.Amount,
                    Product = ToProductViewModel(cartDbItem.Product)
                };
                cartItems.Add(cartItem);
            }
            return cartItems;
        }

        public static UserViewModel ToUserViewModel(this User user)
        {
            return new UserViewModel
            {
                Name = user.UserName,
                Phone = user.PhoneNumber
            };
        }

        public static OrderViewModel ToOrderViewModel(Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                CreateDateTime = order.CreateDateTime,
                Status = (OrderStatusViewModel)(int)order.Status,
                User = ToUserDeliveryInfoViewModel(order.User),
                Items = ToCartItemViewModels(order.Items)
            };
        }      

        public static UserDeliveryInfoViewModel ToUserDeliveryInfoViewModel(UserDeliveryInfo user)
        {
            return new UserDeliveryInfoViewModel
            {
                  LastName = user.LastName,
                  FirstName = user.FirstName,
                  PatronymicName = user.PatronymicName,
                  Phone = user.Phone,
                  Town = user.Town,
                  Street = user.Street,
                  House = user.House,
                  Flat = user.Flat,
                  Email = user.Email,
                  Index = user.Index        
            };
        }
    }
}
