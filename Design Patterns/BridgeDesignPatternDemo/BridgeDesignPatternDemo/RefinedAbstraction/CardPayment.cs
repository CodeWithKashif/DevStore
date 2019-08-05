using BridgeDesignPatternDemo.Abstraction;

namespace BridgeDesignPatternDemo.RefinedAbstraction
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class CardPayment : Payment
    {
        public CardPayment()
        {
            
        }

        public override void MakePayment()
        {
            PaymentSystem.ProcessPayment("Card Payment");
        }
    }
}