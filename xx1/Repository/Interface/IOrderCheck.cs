using xx1.Data_Transfer_Object_DTOs_;
using xx1.Entities_Models_;

namespace xx1.Repository.Interface
{
    public interface IOrderCheck : IDisposable
    {
        IEnumerable<OrderCheckEntity> All();
        int AddOrderCheck(int productid, OrderCheckEntity orderCheck);
    }
}
