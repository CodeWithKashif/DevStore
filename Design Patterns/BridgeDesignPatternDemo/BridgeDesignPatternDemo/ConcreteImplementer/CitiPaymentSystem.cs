using System;
using BridgeDesignPatternDemo.Implementer;

namespace BridgeDesignPatternDemo.ConcreteImplementer
{
    /// <summary>
    /// ConcreteImplementor 
    /// </summary>
    public class CitiPaymentSystem : IPaymentSystem
    {
        public CitiPaymentSystem()
        {
            
        }

        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using CitiBank gateway for  " + paymentSystem);
        }
    }
}