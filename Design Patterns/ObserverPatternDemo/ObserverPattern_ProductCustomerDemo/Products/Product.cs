using System;
using System.Collections.Generic;

namespace ObserverPattern_ProductCustomerDemo.Products
{
    /// <summary>
    /// The Subject abstract class
    /// </summary>
    abstract class Product
    {
        private int _price;
        private readonly List<ICustomer> _customers = new List<ICustomer>();

        protected Product(int price)
        {
            _price = price;
        }

        public void Subscribe(ICustomer customer)
        {
            _customers.Add(customer);
        }

        public void UnSubscribe(ICustomer customer)
        {
            _customers.Remove(customer);
        }

        public void NotifyCustomer()
        {
            foreach (ICustomer customer in _customers)
            {
                customer.Notify(this);
            }

            //Console.WriteLine("");
        }

        public int Priced
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    NotifyCustomer(); //Automatically notify our observers of price changes
                }
            }
        }

        private bool _isAvailable;

        public bool IsAvailable
        {
            get
            {
                return _isAvailable; 
            }
            set
            {
                _isAvailable = value;

                if (value)
                {
                    NotifyCustomer();
                }
            }
        }



    }
}