using xx1.Db;
using xx1.Entities_Models_;
using xx1.Repository.Interface;

namespace xx1.Repository.Implementation
{
    public class EmployeeRepositiory : IEmployee
    {
        private readonly ApplicationDBContext dbContext;
        public EmployeeRepositiory(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public int AddEmployee(EmployeeEntity employee)
        {
            int result = -1;
            if (employee == null)
            {
                result = -1;
            }
            else
            {
                employee.RoleId = 8678576;
                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();
                result = employee.Id;
            }
            return result;
        }

        public IEnumerable<EmployeeEntity> GetAll()
        {
            return dbContext.Employees.ToList();
        }

        public EmployeeEntity GetEmployeeById(int id)
        {
            var employee = dbContext.Employees.FirstOrDefault(employee => employee.Id == id);
            return employee;
        }
        int IEmployee.UpdateEmployeeDetails(EmployeeEntity employee, int Id)
        {
            var employeeEntity = dbContext.Employees.Where(x => x.Id == Id).FirstOrDefault();
            int result = 0;
            if (employee == null)
            {
                return result = -1;
            }
            else
            {
                employeeEntity.Id = Id;
                employeeEntity.FirstName = employee.FirstName;
                employeeEntity.LastName = employee.LastName;
                employeeEntity.Password = employee.Password;
                employeeEntity.Email = employee.Email;
                employeeEntity.DateOfBirth = employee.DateOfBirth;

                dbContext.SaveChanges();
                return result = Id;
            }
        }
    }
}
