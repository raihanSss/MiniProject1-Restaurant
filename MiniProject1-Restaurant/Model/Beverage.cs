namespace MiniProject1_Restaurant.Model
{
    public class Beverage : MenuItem
    {
        private string _size;

        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public override decimal CalculatePrice()
        {
            
            return Price;
        }
    }
}
