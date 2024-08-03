namespace MiniProject1_Restaurant.Model
{
    public class Dessert : MenuItem
    {
        private string _sugarLevel;

        public string SugarLevel
        {
            get { return _sugarLevel; }
            set { _sugarLevel = value; }
        }

        public override decimal CalculatePrice()
        {
           
            return Price;
        }
    }
}
