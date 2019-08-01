using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var bbqNation = new BarbequeNation
            {
                Id = 123,
                CustomerName = "Customer Name",
                FoodType = FoodType.NonVeg
            };


            int placeOrder = bbqNation.PlaceOrder();
            Console.WriteLine("So Final bill amount per person is " + placeOrder);

            Console.ReadKey();
        }


    }
}
