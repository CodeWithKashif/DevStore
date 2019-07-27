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

        public Customer(string email, double purchaseThreshold)
        {
            _email = email;
            _purchaseThreshold = purchaseThreshold;
        }

        public void Notify(Product product)
        {
            //Console.WriteLine("Notified {0} of {1}'s " + " price change to {2:C} .", _email, product.GetType().Name, product.Priced);
            if (product.Priced < _purchaseThreshold)
            {
                Console.WriteLine(_email + " wants to buy and " + product.GetType().Name + "!");
            }
        }
    }
}