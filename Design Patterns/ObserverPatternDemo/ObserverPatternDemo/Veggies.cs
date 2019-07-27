using System;
using System.Collections.Generic;

namespace ObserverPatternDemo
{
    /// <summary>
    /// The Subject abstract class
    /// </summary>
    abstract class Veggies
    {
        private double _pricePerPound;
        private readonly List<IRestaurant> _restaurants = new List<IRestaurant>();

        protected Veggies(double pricePerPound)
        {
            _pricePerPound = pricePerPound;
        }

        public void Subscribe(IRestaurant restaurant)
        {
            _restaurants.Add(restaurant);
        }

        public void UnSubscribe(IRestaurant restaurant)
        {
            _restaurants.Remove(restaurant);
        }

        public void Notify()
        {
            foreach (IRestaurant restaurant in _restaurants)
            {
                restaurant.Update(this);
            }

            Console.WriteLine("");
        }

        public double PricePerPound
        {
            get { return _pricePerPound; }
            set
            {
                if (_pricePerPound != value)
                {
                    _pricePerPound = value;
                    Notify(); //Automatically notify our observers of price changes
                }
            }
        }
    }
}