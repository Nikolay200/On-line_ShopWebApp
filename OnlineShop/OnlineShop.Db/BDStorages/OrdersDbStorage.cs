﻿using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Db
{
    public class OrdersDbStorage : IOrdersStorage

    //Хранилище, которое хранит все созданные заказы
    {
        private readonly DatabaseContext databaseContext;

        public OrdersDbStorage(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public void Add(Order order)
        {
            databaseContext.Orders.Add(order);
            databaseContext.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return databaseContext.Orders.Include(x => x.User).Include(x => x.Items).ThenInclude(x => x.Product).ToList();
        }

        public Order TryGetById(Guid orderId)
        {
            return databaseContext.Orders.Include(x => x.User).Include(x => x.Items).ThenInclude(x => x.Product).FirstOrDefault(o => o.Id == orderId);            
        }

        public void UpdateStatus(Guid orderId, OrderStatus newStatus)
        {
            var order = TryGetById(orderId);
            if (order != null)
            {
                order.Status = newStatus;
            }
        }
    }
}
