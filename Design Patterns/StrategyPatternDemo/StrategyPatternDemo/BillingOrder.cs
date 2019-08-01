using System;

namespace StrategyPatternDemo
{
    class BillingOrder
    {
        public IBillingStrategy BillingStrategy;
        public FoodType FoodType { get; set; }

        public int BillAmount
        {
            get
            {
                if (FoodType == FoodType.NonVeg)
                    return 1000;

                return 600;
            }
        }

        public BillingOrder()
        {
            
        }

        public BillingOrder(FoodType foodType)
        {
            FoodType = foodType;
        }

        public int GetFinalBill()
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    BillingStrategy = new HighDiscountBillingStrategy();
                    break;

                case DayOfWeek.Saturday:
                    BillingStrategy = new LowDiscountBillingStrategy();
                    break;

                case DayOfWeek.Sunday:
                    BillingStrategy = new NoDiscountBillingStrategy();
                    break;
            }

            return BillingStrategy.GetFinalBill(this.BillAmount);
        }

    }
}