using System;
using System.Collections.Generic;

namespace ObserverPattern_ProductCustomerDemo.Products
{
    /// <summary>
    /// The Subject abstract class
    /// </summary>
    abstract class Product
    {
        private readonly List<ICustomer> _priceDropAlertCusomers = new List<ICustomer>();
        private readonly List<ICustomer> _stockAlertCustomers = new List<ICustomer>();

        private int _price;

        protected Product(int price)
        {
            _price = price;
        }

        public void SubscribePriceAlert(ICustomer customer)
        {
            _priceDropAlertCusomers.Add(customer);
        }

        public void UnSubscribePriceAlert(ICustomer customer)
        {
            _priceDropAlertCusomers.Remove(customer);
        }

        public void SubscribeStockAlert(ICustomer customer)
        {
            _stockAlertCustomers.Add(customer);
        }

        public void UnSubscribeStockAlert(ICustomer customer)
        {
            _stockAlertCustomers.Remove(customer);
        }

        

        public void PriceDropAlert()
        {
            foreach (ICustomer customer in _priceDropAlertCusomers)
            {
                customer.PriceDropAlert(this);
            }

            Console.WriteLine("");
        }

        public void BackInStockAlert()
        {
            foreach (ICustomer customer in _stockAlertCustomers)
            {
                customer.StockAlert(this);
            }
            Console.WriteLine("");
        }

        public int Priced
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    PriceDropAlert(); //Automatically notify our observers of price changes
                }
            }
        }

        private bool _isInStock;

        public bool IsInStock
        {
            get
            {
                return _isInStock; 
            }
            set
            {
                _isInStock = value;

                if (value)
                {
                    //_customers.ForEach(x=>x.InSctockNotify(this));
                    BackInStockAlert(); //Automatically notify our observers of price changes
                }
            }
        }

    }
}