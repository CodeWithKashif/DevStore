using System.Collections.Generic;
using System.Linq;
using StrategyPattern_SalaryCalculateDemo.Enum;

namespace StrategyPattern_SalaryCalculateDemo.Strategy
{
    /// <summary>
    /// Concrete Strategy Class for Senior developer
    /// </summary>
    public class SeniorDevBillingCalculator : IBillingCalculator
    {
        public double CalculateTotalBillingAmount(IEnumerable<DeveloperReport> reports) =>
            reports
                .Where(r => r.Level == DeveloperLevel.Senior)
                .Select(r => r.CalculateSalary() * 1.2)
                .Sum();
    }
}