namespace StrategyPatternDemo
{
    public interface IBillingStrategy
    {
        int GetFinalBill(int billAmount);
    }

    class NoDiscountBillingStrategy : IBillingStrategy
    {
        public int GetFinalBill(int billAmount)
        {
            return billAmount;
        }
    }

    class HighDiscountBillingStrategy : IBillingStrategy
    {
        public int GetFinalBill(int billAmount)
        {
            return (int)(billAmount - billAmount * 0.4);
        }
    }

    class LowDiscountBillingStrategy : IBillingStrategy
    {
        public int GetFinalBill(int billAmount)
        {
            return (int) (billAmount - billAmount * 0.1);
        }
    }
}