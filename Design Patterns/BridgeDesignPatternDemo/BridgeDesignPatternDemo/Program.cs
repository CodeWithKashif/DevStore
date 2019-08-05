using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeDesignPatternDemo.Abstraction;
using BridgeDesignPatternDemo.ConcreteImplementer;
using BridgeDesignPatternDemo.RefinedAbstraction;

namespace BridgeDesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Card Payment - with CITI Payment System
            Payment order = new CardPayment
            {
                PaymentSystem = new CitiPaymentSystem()
            };
            order.MakePayment();

            //Card Payment - with IDBI PaymentSystem
            Payment order2 = new CardPayment
            {
                PaymentSystem = new IDBIPaymentSystem()
            };
            order2.MakePayment();

            //NetBanking - with CitiPaymentSystem
            Payment order3 = new NetBankingPayment
            {
                PaymentSystem = new CitiPaymentSystem()
            };
            order3.MakePayment();

            Console.ReadKey();
        }
    }
}
