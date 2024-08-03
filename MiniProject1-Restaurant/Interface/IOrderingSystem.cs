using MiniProject1_Restaurant.Model;

namespace MiniProject1_Restaurant.Interface
{
    public interface IOrderingSystem
    {
        string AddRestaurant(Restaurant restaurant);
        int PlaceOrder(string restaurantName, List<MenuItem> orderedItems);
        Order DisplayOrderDetails(int orderNumber);
        string CancelOrder(int orderNumber);
        string GetOrderStatus(int orderNumber);
    }
}
