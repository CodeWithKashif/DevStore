using BridgeDesignPatternDemo.Implementer;

namespace BridgeDesignPatternDemo.Abstraction
{
    /// <summary>
    /// Abstraction 
    /// </summary>
    public abstract class Payment
    {
        public IPaymentSystem PaymentSystem;
        public abstract void MakePayment();
    }
}