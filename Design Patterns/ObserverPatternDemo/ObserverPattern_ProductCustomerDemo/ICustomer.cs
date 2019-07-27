using ObserverPattern_ProductCustomerDemo.Products;

namespace ObserverPattern_ProductCustomerDemo
{
    /// <summary>
    /// The Observer interface
    /// </summary>
    interface ICustomer
    {
        void Notify(Product product);
    }
}