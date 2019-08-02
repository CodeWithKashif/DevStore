using System;
using ObserverPattern_ProductCustomerDemo.Products;

namespace ObserverPattern_ProductCustomerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create price watch for iPhone and attach restaurants that buy carrots from suppliers.
            var iphone = new Iphone(50000);

            iphone.SubscribePriceAlert(new Customer("Mackay@gmail.com", 45000));
            iphone.SubscribePriceAlert(new Customer("Johnny@yahoo.com", 40000));
            iphone.SubscribePriceAlert(new Customer("abc@gmail.com", 42000));

            var ipad = new Ipad(40000);
            ipad.SubscribePriceAlert(new Customer("user1@gmail.com", 30000));
            ipad.SubscribePriceAlert(new Customer("user2@gmail.com", 10000));

            //Adding subscriber for back in Stock alert
            ipad.SubscribeStockAlert(new Customer("user3@gmail.com", true));
            ipad.SubscribeStockAlert(new Customer("user4@gmail.com", false));
            ipad.SubscribeStockAlert(new Customer("user5@gmail.com", true));


            //-----Actions being performed by admin in admin section ---------
            AdministratorAcitivity(iphone, ipad);


            Console.ReadKey();
        }

        /// <summary>
        /// Actions being performed by admin in admin section 
        /// </summary>
        private static void AdministratorAcitivity(Iphone iphone, Ipad ipad)
        {
            //// Fluctuating prices will notify subscribing customer for Iphone
            iphone.Priced = 44000;

            //// Fluctuating prices will notify subscribing customer for Ipad
            ipad.Priced = 25000;

            //ipad is back in stock now so it will notify its subscriber
            ipad.IsInStock = true;
        }
    }
}
