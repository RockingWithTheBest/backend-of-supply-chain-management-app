using Back_End.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using xx1.Db;
using xx1.Entities_Models_;
using xx1.Repository.Interface;

namespace xx1.Repository.Implementation
{
    public class OrderCheckRepository : IOrderCheck
    {
        public ApplicationDBContext context;
        public OrderCheckRepository(ApplicationDBContext applicationDBContext)
        {
            this.context = applicationDBContext;
        }

        public int AddOrderCheck(int productid, OrderCheckEntity orderCheck)
        {
            var productEntity = context.Products.FirstOrDefault(o => o.Id == productid);


            int result = -1;
            if (productEntity == null)
            {
                Console.WriteLine($"Product with ID {productid} does not exist.");
                return result;
            }
            string create = productEntity.Name;
            Console.WriteLine("---- " + create);
            if (orderCheck == null)
            {
                orderCheck = new OrderCheckEntity();
            }

            //Updating the Stock count for the productEntity
            productEntity.StockQuantity = productEntity.StockQuantity - orderCheck.ProductQuantity;

            //In the case of the productEntity.StockQuantity of a particular product being 0
            //The product is delete
            if (productEntity.StockQuantity == 0 || productEntity.StockQuantity < 0)
            {
                var product = context.Products.Find(productid);
                context.Remove(product);
                context.SaveChanges();
            }
            context.SaveChanges();


            orderCheck.ProductName = create;
            context.OrderChecks.Add(orderCheck);
            context.SaveChanges();

            return orderCheck.Id;
        }

        public IEnumerable<OrderCheckEntity> All()
        {
            var order = context.OrderChecks.ToList();
            return order;
        }


        public void Dispose()
        {
            context?.Dispose();
        }
    }
}
