using Back_End.Models;
using Microsoft.EntityFrameworkCore;
using xx1.Db;
using xx1.Entities_Models_;
using xx1.Repository.Interface;

namespace xx1.Repository.Implementation
{
    public class InventoryRepository : IInventory
    {
        private readonly ApplicationDBContext dBContext;
        public InventoryRepository(ApplicationDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public int AddInventory(InventoryEntity inventory, int OrderId)
        {
            var order = dBContext.Orders.Find(OrderId);
            if (order == null)
            {
                return -1;
            }
            var customer = dBContext.Customers.Find(order.CustomerId);
            if (customer == null)
            {
                return -1;
            }
            var ordercheck = dBContext.OrderChecks.Where(x => x.OrderId == OrderId).FirstOrDefault();
            var product = dBContext.Products.Where(x => x.Id == order.ProductId).FirstOrDefault();
            inventory = new InventoryEntity
            {
                OrderId = order.Id,
                CustomerNames = customer.FirstName + " " + customer.LastName,
                Quantity = order.Quantity,
                ProductName = ordercheck.ProductName,
                OrderCheckId = ordercheck.Id,
                PricePaid = (product.Price * order.Quantity),
                Status = "New Order",
                CustomerId = order.CustomerId
            };
            dBContext.Inventories.Add(inventory);
            dBContext.SaveChanges();
            return inventory.Id;
        }

        public void Dispose()
        {
            this.dBContext?.Dispose();
        }

        public IEnumerable<InventoryEntity> GetAllInventory()
        {
            var inventory = dBContext.Inventories.ToList();
            return inventory;
        }

        public IEnumerable<InventoryEntity> GetConfirmedOrder(int customerId)
        {
            var inventList = dBContext.Inventories.Where(x => x.CustomerId == customerId).ToList();
            var NewOrders = inventList.Where(x => x.Status == "Recieved Order");
            return NewOrders;
        }

        public IEnumerable<InventoryEntity> GetNewOrder(int customerId)
        {
            var inventList = dBContext.Inventories.Where(x => x.CustomerId == customerId).ToList();
            var NewOrders = inventList.Where(x => x.Status == "New Order").ToList();
            foreach (var order in NewOrders)
            {
                Console.WriteLine(order.OrderId);
            }
            return NewOrders;
        }

        public InventoryEntity UpdateOrderStatus(int Id)
        {
            var inventoryList = new InventoryEntity();
            inventoryList = dBContext.Inventories.Where(x => x.Id == Id).FirstOrDefault();
            inventoryList.Status = "Recieved Order";
            dBContext.SaveChanges();
            return inventoryList;
        }
    }
}
