using MiniProject1_Restaurant.Interface;

namespace MiniProject1_Restaurant.Model
{
    public class OnlineFoodOrderingSystem : IOrderingSystem
    {
        private List<Restaurant> _restaurants;
        private int _orderCounter;

        public OnlineFoodOrderingSystem()
        {
            _restaurants = new List<Restaurant>();
            _orderCounter = 1;
        }

        public string AddRestaurant(Restaurant restaurant)
        {
            _restaurants.Add(restaurant);
            return "Restoran berhasil ditambah";
        }

        public int PlaceOrder(string restaurantName, List<MenuItem> orderedItems)
        {
            var restaurant = _restaurants.FirstOrDefault(r => r.Name == restaurantName);
            if (restaurant != null)
            {
                var order = new Order
                {
                    OrderNumber = _orderCounter++,
                    OrderedItems = orderedItems
                };
                restaurant.ReceiveOrder(order);
                return order.OrderNumber;
            }
            return -1; 
        }

        public Order DisplayOrderDetails(int orderNumber)
        {
            foreach (var restaurant in _restaurants)
            {
                var order = restaurant.Orders.FirstOrDefault(o => o.OrderNumber == orderNumber);
                if (order != null)
                {
                    return order;
                }
            }
            return null; 
        }

        public string CancelOrder(int orderNumber)
        {
            foreach (var restaurant in _restaurants)
            {
                var order = restaurant.Orders.FirstOrDefault(o => o.OrderNumber == orderNumber);
                if (order != null)
                {
                    restaurant.Orders.Remove(order);
                    return "Orderan behasil di cancel";
                }
            }
            return "Order tidak ada";
        }

        public string GetOrderStatus(int orderNumber)
        {
            foreach (var restaurant in _restaurants)
            {
                var order = restaurant.Orders.FirstOrDefault(o => o.OrderNumber == orderNumber);
                if (order != null)
                {
                    return "Order sedang diproses";
                }
            }
            return "Order tidak ada";
        }
    }
}