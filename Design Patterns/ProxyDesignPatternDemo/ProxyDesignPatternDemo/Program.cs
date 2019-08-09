using System;

namespace ProxyDesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Order processing by Real subject class i.e. FoodServer
            var foodServer = new FoodServer();
            foodServer.TakeOrder("Pizza");
            foodServer.DeliverOrder();
            foodServer.ProcessPayment("100$");

            Console.WriteLine("--------------------------");
            //Order processing by Real Proxy class i.e. TaineeFoodServerProxy
            var taineeFoodServerProxy = new TaineeFoodServerProxy();
            taineeFoodServerProxy.TakeOrder("Pasta");
            taineeFoodServerProxy.DeliverOrder();
            taineeFoodServerProxy.ProcessPayment("100$");

            Console.ReadLine();
        }
    }
}
