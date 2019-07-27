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
        private readonly List<ICustomer> _priceDropCusomers = new List<ICustomer>();
        private readonly List<ICustomer> _stockAlerCustomers = new List<ICustomer>();

        protected Product(int price)
        {
            _price = price;
        }

        public void SubscribePriceAlert(ICustomer customer)
        {
            _priceDropCusomers.Add(customer);
        }

        public void UnSubscribePriceAlert(ICustomer customer)
        {
            _priceDropCusomers.Remove(customer);
        }

        public void SubscribeStockAlert(ICustomer customer)
        {
            _stockAlerCustomers.Add(customer);
        }

        public void UnSubscribeStockAlert(ICustomer customer)
        {
            _stockAlerCustomers.Remove(customer);
        }

        

        public void PriceDropAlert()
        {
            foreach (ICustomer customer in _priceDropCusomers)
            {
                customer.PriceDropAlert(this);
            }
        }

        public void BackInStockAlert()
        {
            foreach (ICustomer customer in _stockAlerCustomers)
            {
                customer.StockAlert(this);
            }
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