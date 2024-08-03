namespace MiniProject1_Restaurant.Model
{
    public class Food : MenuItem
    {
        private string _spiciness;

        public string Spiciness
        {
            get { return _spiciness; }
            set { _spiciness = value; }
        }

        public override decimal CalculatePrice()
        {
            
            return Price;
        }
    }
}
