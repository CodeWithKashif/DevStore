using System;
using System.Collections.Generic;

namespace DecoratorPatternDemo
{
    /// <summary>
    /// https://exceptionnotfound.net/decorator-the-daily-design-pattern/
    /// A ConcreteDecorator. This class will impart "responsibilities" onto the dishes 
    /// (e.g. whether or not those dishes have enough ingredients left to order them)
    /// </summary>
    class AvailableDish : DishDecorator
    {
        public int NumAvailable { get; set; } //How many can we make?
        protected List<string> Customers = new List<string>();

        public AvailableDish(Dish dish, int numAvailable) : base(dish)
        {
            NumAvailable = numAvailable;
        }

        public void OrderItem(string customerName)
        {
            if (NumAvailable > 0)
            {
                Customers.Add(customerName);
                NumAvailable--;
            }
            else
            {
                Console.WriteLine("\nNot enough ingredients for " + customerName + "'s order!");
            }
        }

        public override void Display()
        {
            base.Display();

            foreach (var customer in Customers)
            {
                Console.WriteLine("Ordered by " + customer);
            }
        }
    }
}