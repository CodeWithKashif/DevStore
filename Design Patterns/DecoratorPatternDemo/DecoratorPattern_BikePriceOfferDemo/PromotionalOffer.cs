namespace DecoratorPattern_BikePriceOfferDemo
{
    /// <summary>
    /// // 'ConcreteDecorator' class
    /// </summary>
    public class PromotionalOffer : BikeDecorator
    {
        private readonly IBike _bike;
        public int PromotionalDiscount;

        public PromotionalOffer(IBike bike)
        {
            _bike = bike;
        }

        public override string GetBikeDetails()
        {
            return "Promotional offer";
        }

        public override int GetPrice()
        {
            return _bike.GetPrice() - PromotionalDiscount;
        }
    }
}