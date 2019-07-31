namespace DecoratorPattern_BikePriceOfferDemo
{
    /// <summary>
    /// // 'ConcreteComponent' class
    /// </summary>
    public class RoyalEnfield : IBike
    {
        public string GetBikeDetails()
        {
            return "Royal Enfield 350 CC classic Model";
        }

        public int GetPrice()
        {
            return 150000;
        }

    }
}