namespace DecoratorPattern_BikePriceOfferDemo
{
    /// <summary>
    /// //'Decorator' abstract class
    /// </summary>
    public abstract class BikeDecorator : IBike
    {
        public abstract string GetBikeDetails();
        public abstract int GetPrice();
    }
}