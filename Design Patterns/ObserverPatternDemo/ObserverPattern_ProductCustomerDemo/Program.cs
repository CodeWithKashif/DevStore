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

            iphone.Subscribe(new Customer("Mackay@gmail.com", 45000));
            iphone.Subscribe(new Customer("Johnny@yahoo.com", 40000));
            iphone.Subscribe(new Customer("abc@gmail.com", 42000));

            var ipad = new Ipad(20000);
            ipad.Subscribe(new Customer("user1@gmail.com", 45000));
            ipad.Subscribe(new Customer("user2@gmail.com", 45000));

            // Fluctuating prices will notify subscribing customer.
            iphone.Priced = 44000;

            ipad.Priced = 30000;
            ipad.Priced = 15000;

            Console.ReadKey();
        }
    }
}
