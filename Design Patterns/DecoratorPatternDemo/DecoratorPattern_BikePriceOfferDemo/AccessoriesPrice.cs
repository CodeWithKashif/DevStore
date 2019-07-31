namespace DecoratorPattern_BikePriceOfferDemo
{
    /// <summary>
    /// // 'ConcreteDecorator' class
    /// </summary>
    public class AccessoriesPrice : BikeDecorator
    {
        private readonly IBike _bike;
        public int AccessoriesCharge;

        public AccessoriesPrice(IBike bike)
        {
            _bike = bike;
        }


        public override string GetBikeDetails()
        {
            return "Accessories Charges";
        }

        public override int GetPrice()
        {
            return _bike.GetPrice() + AccessoriesCharge;
        }
    }
}