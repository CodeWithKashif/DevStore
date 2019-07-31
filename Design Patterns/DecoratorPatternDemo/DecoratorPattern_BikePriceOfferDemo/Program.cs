using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_BikePriceOfferDemo
{
    class Program
    {
        /// <summary>
        /// http://gyanendushekhar.com/2016/08/20/decorator-design-pattern-c/
        ///
        /// Decorator Design Pattern
        /// The decorator design pattern is used where there is need to add additional functionality to already existing object
        /// without altering its structure.This design pattern provides a decorator class which acts as the wrapper of the existing class.
        /// This wrapper class is responsible for adding additional functionalities to the existing class.
        ///
        /// Gang of Four(GoF) definition:
        /// Attach additional responsibilities to an object dynamically.Decorators provide a flexible alternative to subclassing
        /// for extending functionality.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var royalEnfieldBike = new RoyalEnfield();
            Console.WriteLine("-------------------" + royalEnfieldBike.GetBikeDetails() + "--------------------");
            Console.WriteLine("Royal Enfield Bike Base Price : " + royalEnfieldBike.GetPrice());
            
            var promotionalOffer = new PromotionalOffer(royalEnfieldBike)
            {
                PromotionalDiscount = 25000
            };
            Console.WriteLine("Price After Promotinal Discount (25000) : " + promotionalOffer.GetPrice());
            
            var trasportOfficeCharges = new TransportOfficeCharges(promotionalOffer)
            {
                TransportOfficeCharge = 20000
            };
            Console.WriteLine("Price After Tranport Charges (20000) : " + trasportOfficeCharges.GetPrice());
            
            var accessoriesPrice = new AccessoriesPrice(trasportOfficeCharges)
            {
                AccessoriesCharge = 15000
            };
            Console.WriteLine("Price After adding accessories (15000) : " + accessoriesPrice.GetPrice());

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("So final On road Price : " + accessoriesPrice.GetPrice());
 
            Console.ReadLine();
        }
    }
}
