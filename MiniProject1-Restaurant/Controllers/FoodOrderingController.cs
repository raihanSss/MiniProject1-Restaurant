using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniProject1_Restaurant.Model;

namespace MiniProject1_Restaurant.Controllers
{
    [Route("api/food-order")]
    [ApiController]
    public class FoodOrderingController : ControllerBase
    {
        private static OnlineFoodOrderingSystem _orderingSystem = new OnlineFoodOrderingSystem();

        [HttpPost("addRestaurant")]
        public ActionResult<string> AddRestaurant([FromBody] Restaurant restaurant)
        {
            string result = _orderingSystem.AddRestaurant(restaurant);
            return Ok(result);
        }

        [HttpPost("placeOrder")]
        public ActionResult<int> PlaceOrder([FromBody] OrderRequest orderRequest)
        {
            int orderNumber = _orderingSystem.PlaceOrder(orderRequest.RestaurantName, orderRequest.OrderedItems);
            if (orderNumber > 0)
            {
                return Ok(orderNumber);
            }
            return BadRequest("Gagal.");
        }

        [HttpGet("displayOrder/{orderNumber}")]
        public ActionResult<Order> DisplayOrderDetails(int orderNumber)
        {
            Order order = _orderingSystem.DisplayOrderDetails(orderNumber);
            if (order != null)
            {
                return Ok(order);
            }
            return NotFound("Order tidak ada");
        }

        [HttpDelete("cancelOrder/{orderNumber}")]
        public ActionResult<string> CancelOrder(int orderNumber)
        {
            string result = _orderingSystem.CancelOrder(orderNumber);
            return Ok(result);
        }

        [HttpGet("getOrderStatus/{orderNumber}")]
        public ActionResult<string> GetOrderStatus(int orderNumber)
        {
            string status = _orderingSystem.GetOrderStatus(orderNumber);
            return Ok(status);
        }
    }

    public class OrderRequest
    {
        public string RestaurantName { get; set; }
        public List<MenuItem> OrderedItems { get; set; }
    }
}
