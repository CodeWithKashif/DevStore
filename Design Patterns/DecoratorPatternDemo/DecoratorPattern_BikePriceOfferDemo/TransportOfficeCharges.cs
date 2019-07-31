namespace DecoratorPattern_BikePriceOfferDemo
{
    /// <summary>
    /// // 'ConcreteDecorator' class
    /// </summary>
    public class TransportOfficeCharges : BikeDecorator
    {
        private readonly IBike _bike;
        public int TransportOfficeCharge;

        public TransportOfficeCharges(IBike bike)
        {
            _bike = bike;
        }

        public override string GetBikeDetails()
        {
            return "Transport Office Charges";
        }

        public override int GetPrice()
        {
            return _bike.GetPrice() + TransportOfficeCharge;
        }

    }
}