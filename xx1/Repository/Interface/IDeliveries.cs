using Back_End.Models;

namespace xx1.Repository.Interface
{
    public interface IDeliveries
    {
        IEnumerable<DeliveryEntity> AllRecords();
        int EditRecords(int id, DeliveryEntity newRecord);
    }
}
