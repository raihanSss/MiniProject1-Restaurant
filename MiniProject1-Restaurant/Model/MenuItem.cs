namespace MiniProject1_Restaurant.Model
{
    public abstract class MenuItem
    {
        private string _name;
        private decimal _price;
        private string _description;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public abstract decimal CalculatePrice();
    }
}