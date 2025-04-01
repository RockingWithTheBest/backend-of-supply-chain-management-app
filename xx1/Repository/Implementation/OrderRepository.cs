﻿using Back_End.Models;
using xx1.Db;
using xx1.Repository.Interface;

namespace xx1.Repository.Implementation
{
    public class OrderRepository : IOrder
    {
        private readonly ApplicationDBContext db;
        public OrderRepository(ApplicationDBContext db)
        {
            this.db = db;
        }

        public int AddOrder(OrderEntity order)
        {
            if(order == null)
            {
                return -1;
            }
            else
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return order.Id;
            }
        }

        public void Dispose()
        {
            db?.Dispose();
        }

        public IEnumerable<OrderEntity> GetAllOrders()
        {
            var orders = db.Orders.ToList();
            return orders;
        }

        public OrderEntity GetOrderById(int id)
        {
            var order = db.Orders.FirstOrDefault(o => o.Id == id);
            return order;
        }
    }
}
