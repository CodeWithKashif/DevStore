using System;
using ObserverPattern_ProductCustomerDemo.Products;

namespace ObserverPattern_ProductCustomerDemo
{
    /// <summary>
    /// The ConcreteObserver class
    /// </summary>
    class Customer : ICustomer
    {
        private readonly string _email;
        private readonly double _purchaseThreshold;
        private readonly bool _stockAlert;

        public Customer(string email, double purchaseThreshold)
        {
            _email = email;
            _purchaseThreshold = purchaseThreshold;
        }

        public Customer(string email, bool stockAlert)
        {
            _email = email;
            _stockAlert = stockAlert;
        }

        public void PriceDropAlert(Product product)
        {
            if (product.Priced < _purchaseThreshold)
            {
                Console.WriteLine($"Hey {_email} price is dropped for {product.GetType().Name} and it is in your budget now..!");
            }
        }

        public void StockAlert(Product product)
        {
            if (_stockAlert)
            {
                Console.WriteLine($"Hey {_email}, {product.GetType().Name} is back in Stock now!");
            }
        }

    }
}