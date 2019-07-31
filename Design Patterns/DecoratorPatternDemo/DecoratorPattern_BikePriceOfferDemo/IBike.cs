namespace DecoratorPattern_BikePriceOfferDemo
{
    /// <summary>
    /// 'Component' interface
    /// </summary>
    public interface IBike
    {
        string GetBikeDetails();

        int GetPrice();
    }
}