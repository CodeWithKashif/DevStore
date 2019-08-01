using System.Security.AccessControl;

namespace StrategyPatternDemo
{
    class BarbequeNation
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public FoodType FoodType { get; set; }
        
        public int PlaceOrder()
        {
            var billingOrder= new BillingOrder(FoodType);
            int finalAmountBill = billingOrder.GetFinalBill();
            return finalAmountBill;
        }

    }
}