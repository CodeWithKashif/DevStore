using System;
using BridgeDesignPatternDemo.Implementer;

namespace BridgeDesignPatternDemo.ConcreteImplementer
{
    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class IDBIPaymentSystem : IPaymentSystem
    {
        public IDBIPaymentSystem()
        {
            
        }

        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using IDBIBank gateway for  " + paymentSystem);
        }
    }
}