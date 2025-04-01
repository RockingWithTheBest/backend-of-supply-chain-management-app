using Back_End.Models;
using xx1.Db;
using xx1.Repository.Interface;

namespace xx1.Repository.Implementation
{
    public class DeliveriesRepository : IDeliveries
    {
        private readonly ApplicationDBContext app;
        public DeliveriesRepository(ApplicationDBContext dbconnect)
        {
            app = dbconnect;
        }
        public IEnumerable<DeliveryEntity> AllRecords()
        {
            return app.Deliveries.ToList();
        }

        public int EditRecords(int id, DeliveryEntity newRecord)
        {
            int returnValue = 0;
            var record = app.Deliveries.Where(x=>x.Id == id).FirstOrDefault();
            if (record == null)
            {
                return returnValue;
            }
            if(record!=null)
            {
                record.SupplierId = newRecord.SupplierId;
                record.TrackNumber = newRecord.TrackNumber;
                record.DeliveryStatus = newRecord.DeliveryStatus;
                record.EstimatedDelivery = newRecord.EstimatedDelivery;
                app.SaveChanges();
                returnValue = newRecord.Id;
            }
            return returnValue;
        }
    }
}
