using AutoMapper;
using Back_End.Models;
using Microsoft.AspNetCore.Mvc;
using SupplyChain.Data_Transfer_Object_DTOs_;
using xx1.Repository.Interface;

namespace xx1.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class OrderController:ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOrder order;

        public OrderController(IMapper apP, IOrder order)
        {
            this._mapper = apP;
            this.order = order;
        }
        [HttpGet]
        [Route("IndexingAll")]
        public IActionResult Get()
        {
            var orderAll = order.GetAllOrders();
            if (orderAll == null)
            {
                return NotFound("No Orders exist");
            }
            else
            {
                var order = _mapper.Map<IEnumerable<OrderDto>>(orderAll);
                return Ok(order);
            }
        }
        [HttpPost]
        [Route("Add-Order")]
        public IActionResult Add_Order(OrderEntity instance)
        {
            if(instance == null)
            {
                return BadRequest("Cant add the instance because its NULL");
            }
            var orderVar = order.AddOrder(instance);
            if(orderVar == -1)
            {
                return BadRequest("Cant add the object");
            }
            return Ok("Successfully added!!"+orderVar);
        }
    }
}
