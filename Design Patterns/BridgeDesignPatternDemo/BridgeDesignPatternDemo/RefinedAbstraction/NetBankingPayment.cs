using BridgeDesignPatternDemo.Abstraction;

namespace BridgeDesignPatternDemo.RefinedAbstraction
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class NetBankingPayment : Payment
    {
        public NetBankingPayment()
        {
            
        }

        public override void MakePayment()
        {
            PaymentSystem.ProcessPayment("NetBanking Payment");
        }
    }
}