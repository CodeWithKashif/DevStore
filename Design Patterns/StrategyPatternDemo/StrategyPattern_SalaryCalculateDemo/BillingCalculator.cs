using System.Collections.Generic;
using StrategyPattern_SalaryCalculateDemo.Strategy;

namespace StrategyPattern_SalaryCalculateDemo
{
    public class BillingCalculator
    {
        private IBillingCalculator _calculator;

        public BillingCalculator(IBillingCalculator calculator)
        {
            _calculator = calculator;
        }

        public void SetCalculator(IBillingCalculator calculator) => _calculator = calculator;

        public double Calculate(IEnumerable<DeveloperReport> reports) => _calculator.CalculateTotalBillingAmount(reports);
    }
}