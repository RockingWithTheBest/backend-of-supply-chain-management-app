using Back_End.Models;
using xx1.Entities_Models_;

namespace xx1.Repository.Interface
{
    public interface IEmployee
    {
        int AddEmployee(EmployeeEntity employee);
        IEnumerable<EmployeeEntity> GetAll();
        int UpdateEmployeeDetails(EmployeeEntity employee, int Id);
        EmployeeEntity GetEmployeeById(int id);
    }
}
