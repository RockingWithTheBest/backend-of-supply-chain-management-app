using Back_End.Models;
using Microsoft.AspNetCore.Mvc;
using xx1.Repository.Interface;

namespace xx1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController:ControllerBase
    {
        private readonly IDeliveries ideliveries;
        public DeliveriesController(IDeliveries ideliveries)
        {
            this.ideliveries = ideliveries;
        }

        [HttpGet]
        [Route("GetAllRecords")]
        public ActionResult GetRecordZ()
        {
            var record = ideliveries.AllRecords();
            if(record == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(record);
            }
        }
        [HttpPut]
        [Route("UpdateDeliveries")]
        public ActionResult PutRecord(int recordId,DeliveryEntity delivery)
        {
            var record = ideliveries.EditRecords(recordId,delivery);
            if(record == null)
            {
                return BadRequest("Record not found");
            }
            else
            {
                return Ok($"Record with Id {recordId} was successfully updated");
            }
        }
    }
}
