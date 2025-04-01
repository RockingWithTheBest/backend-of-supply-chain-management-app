using Back_End.Models;
using xx1.Db;
using xx1.Repository.Interface;

namespace xx1.Repository.Implementation
{
    public class CustomerRepository : ICustomer
    {
        private readonly ApplicationDBContext dBContext;
        public CustomerRepository(ApplicationDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public int AddCustomer(CustomerEntity customer, int RoleId)
        {
            var role = dBContext.Roles.FirstOrDefault(o => o.Id == RoleId);
            if (role == null) 
            {
                return -1;            
            }
            else
            {
                customer.RoleId = RoleId;
                dBContext.Customers.Add(customer);
                dBContext.SaveChanges();
                return customer.Id;
            }            
        }

        public void Dispose()
        {
            dBContext?.Dispose();
        }

        public IEnumerable<CustomerEntity> GetAllCustomers()
        {
            var customer = dBContext.Customers.ToList();
            return customer;
        }

        public CustomerEntity GetCustomerById(int id)
        {
            var customer = dBContext.Customers.FirstOrDefault(c => c.Id == id);
            return customer;
        }
    }
}
