using System.Collections.Generic;
using System.Linq;
using StrategyPattern_SalaryCalculateDemo.Enum;

namespace StrategyPattern_SalaryCalculateDemo.Strategy
{
    /// <summary>
    /// Concrete Strategy Class for Junior developer
    /// </summary>
    public class JuniorDevBillingCalculator : IBillingCalculator
    {
        public double CalculateTotalBillingAmount(IEnumerable<DeveloperReport> reports) =>
            reports
                .Where(r => r.Level == DeveloperLevel.Junior)
                .Select(r => r.CalculateSalary())
                .Sum();
    }
}