using System.Collections.Generic;

namespace StrategyPattern_SalaryCalculateDemo.Strategy
{
    /// <summary>
    /// Strategy Interface
    /// </summary>
    public interface IBillingCalculator
    {
        double CalculateTotalBillingAmount(IEnumerable<DeveloperReport> reports);
    }
}