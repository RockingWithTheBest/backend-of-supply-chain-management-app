using Microsoft.AspNetCore.Mvc;
using SupplyChain.Data_Transfer_Object_DTOs_;
using xx1.Db;
using xx1.Entities_Models_;
using xx1.Repository.Interface;

namespace xx1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController:ControllerBase
    {
        private readonly IInventory inventory;
        private readonly ApplicationDBContext dbContext;
        public InventoryController(IInventory inventory, ApplicationDBContext dbContext)
        {
            this.inventory = inventory;
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("All")]
        public IActionResult GetAll()
        {
            var InventoryEntity = inventory.GetAllInventory();
            if(InventoryEntity == null)
            {
                return NotFound("No records");
            }
            else
            {
                return Ok(InventoryEntity);
            }
        }

        [HttpGet]
        [Route("GetByNew-OrderByCustomerId")]
        public IActionResult GetNewOrder(int id) 
        { 
            var neworders = inventory.GetNewOrder(id);
            if(neworders == null)
            {
                return NotFound("No order was found");
            }
            else
            {
                return Ok(neworders);
            }
        }

        [HttpGet]
        [Route("GetByConfirmed-OrderByCustomerId")]
        public IActionResult GetConfirmedOrder(int id)
        {
            var confirmOrder = inventory.GetConfirmedOrder(id);
            if (confirmOrder == null)
            {
                return NotFound("No order was found");
            }
            else
            {
                return Ok(confirmOrder);
            }
        }
        [HttpPut]
        [Route("UpdateOrderStatus")]
        public IActionResult Put(int id) 
        { 
            var updateOrder = inventory.UpdateOrderStatus(id);
            if(updateOrder == null)
            {
                return NotFound("Order was not updated");
            }
            else
            {
                return Ok(updateOrder);
            }
        }


        [HttpPost]
        [Route("AddRecordToCart")]
        public IActionResult Add(int OrderId, InventoryEntity invent)
        {
            var record = inventory.AddInventory(invent,OrderId);
            if(record == null)
            {
                return NotFound("Record Could not be added");
            }
            else
            {
                return Ok(record);
            }
            
        }
    }
}
