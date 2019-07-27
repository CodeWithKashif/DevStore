using ObserverPattern_ProductCustomerDemo.Products;

namespace ObserverPattern_ProductCustomerDemo
{
    /// <summary>
    /// The Observer interface
    /// </summary>
    interface ICustomer
    {
        void PriceDropAlert(Product product);
        
        void StockAlert(Product product);
    }
}