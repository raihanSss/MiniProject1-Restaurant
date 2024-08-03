namespace MiniProject1_Restaurant.Model
{
    public class Restaurant
    {
        public string Name { get; set; }
        public List<MenuItem> Menu { get; set; }
        public List<Order> Orders { get; set; }

        public Restaurant()
        {
            Menu = new List<MenuItem>();
            Orders = new List<Order>();
        }

        public void AddMenuItem(MenuItem item)
        {
            Menu.Add(item);
        }

        public void ReceiveOrder(Order order)
        {
            Orders.Add(order);
        }

        public decimal CalculateRevenue()
        {
            return Orders.Sum(o => o.CalculateTotal());
        }
    }
}
