using ApplicationCore.Contracts.Services;
using ApplicationCore.Model.Request;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderServiceAsync orderServiceAsync;

        public OrderController(IOrderServiceAsync orderServiceAsync)
        {
            this.orderServiceAsync = orderServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            return Ok(await orderServiceAsync.GetAllOrdersAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SaveNewOrder(OrderRequestModel model)
        {
            return Ok(await orderServiceAsync.InsertOrderAsync(model));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetOrderByCustomerId(int id)
        {
            //get order by customer id
            return Ok(await orderServiceAsync.GetOrderByIdAsync(id));
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            return Ok(await orderServiceAsync.DeleteOrderAsync(id));
        }
        [HttpPut]
        [Route("update/{id}")]
        public async Task<IActionResult> UpdateOrder(OrderRequestModel model, int id)
        {
            return Ok(await orderServiceAsync.UpdateOrderAsync(model, id));
        }
    }
}
