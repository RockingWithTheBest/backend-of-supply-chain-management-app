using Microsoft.AspNetCore.Mvc;
using xx1.Repository.Interface;
using xx1.Db;
using xx1.Entities_Models_;

namespace xx1.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class OrderCheckController:ControllerBase
    {
        private readonly IOrderCheck IorderCheck;
        private readonly ApplicationDBContext _appBuilder;

        public OrderCheckController (ApplicationDBContext appBuilder, IOrderCheck orderCheck)
        {
            this._appBuilder = appBuilder;
            this.IorderCheck = orderCheck;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get() 
        {
            var orderAll = IorderCheck.All();
            if (orderAll == null)
            {
                return NotFound("No Orders exist");
            }
            else
            {
                return Ok(orderAll);
            }
        }

        [HttpPost]
        [Route("Add-OrderCheck")]
        public IActionResult AddOrder(int productId, OrderCheckEntity orderCheck)
        {
            var order = IorderCheck.AddOrderCheck(productId, orderCheck);
            if(order <= 0)
            {
                return BadRequest("Failed");
            }
            else
            {
                return Ok("Added : " + order);
            }
        }
    }
}
