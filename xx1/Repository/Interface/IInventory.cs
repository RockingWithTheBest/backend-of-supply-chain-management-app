using Back_End.Models;
using xx1.Entities_Models_;

namespace xx1.Repository.Interface
{
    public interface IInventory : IDisposable
    {
        IEnumerable<InventoryEntity> GetAllInventory();
        int AddInventory(InventoryEntity entity, int OrderId);
        IEnumerable<InventoryEntity> GetNewOrder(int CustomerId);
        IEnumerable<InventoryEntity> GetConfirmedOrder(int CustomerId);
        InventoryEntity UpdateOrderStatus(int Id);
    }
}
