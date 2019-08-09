namespace ProxyDesignPatternDemo
{
    /// <summary>
    /// The Subject interface which both the RealSubject and proxy will need to implement
    /// </summary>
    public interface IFoodServer
    {
        void TakeOrder(string order);
        string DeliverOrder();
        void ProcessPayment(string payment);
    }
}