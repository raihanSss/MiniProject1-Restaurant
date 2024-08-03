namespace MiniProject1_Restaurant.Model
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public List<MenuItem> OrderedItems { get; set; }

        public Order()
        {
            OrderedItems = new List<MenuItem>();
        }

        public decimal CalculateTotal()
        {
            return OrderedItems.Sum(item => item.CalculatePrice());
        }
    }
}