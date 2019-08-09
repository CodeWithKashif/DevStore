using System;

namespace ProxyDesignPatternDemo
{
    /// <summary>
    /// The Proxy class, which can substitute for the Real Subject.
    /// Here you can see, the TaineeFoodServerProxy implements its own TakeOrder() and DeliverOrder() methods,
    /// and calls the FoodServer class's ProcessPayment() method.
    /// Since they both implement IServer, the NewServerProxy can be used any place the FoodServer can be used.
    /// </summary>
    class TaineeFoodServerProxy : IFoodServer
    {
        private string _order;
        
        public void TakeOrder(string order)
        {
            Console.WriteLine("New trainee server takes order for " + order + ".");
            _order = order;
        }

        public string DeliverOrder()
        {
            return _order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("New trainee cannot process payments yet!");
            new FoodServer().ProcessPayment(payment);
        }
    }
}