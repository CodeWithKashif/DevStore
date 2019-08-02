using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern_SalaryCalculateDemo.Enum;
using StrategyPattern_SalaryCalculateDemo.Strategy;

namespace StrategyPattern_SalaryCalculateDemo
{
    /// <summary>
    /// https://code-maze.com/strategy/
    /// The Strategy design pattern is a behavioral design pattern which allows us to define different functionalities,
    /// put each functionality/strategy in a separate class which derived from a common Interface and make their objects interchangeable/replacable.
    /// 
    /// When Should We Use the Strategy Design Pattern
    ///---------------------------------------------------
    ///We should use this pattern whenever we have different variations for some functionality
    ///in an object and we want to switch from one type to another at runtime.
    ///Furthermore, if we have similar classes in our project that only differs on how they execute some behavior,
    ///the Strategy pattern should be the right choice for us.
    ///We should consider introducing this pattern in situations where a single class has multiple conditions over different variations
    ///of the same functionality.That’s because the Strategy pattern lets us extract those variations into separate classes(concrete strategies).
    ///Then we can invoke them into the context class.
    ///</summary>

    class Program
    {
        static void Main(string[] args)
        {
            var reports = new List<DeveloperReport>
            {
                new DeveloperReport {Id = 1, Name = "Dev1", Level = DeveloperLevel.Senior, HourlyRate = 30.5, WorkingHours = 160 },
                new DeveloperReport { Id = 2, Name = "Dev2", Level = DeveloperLevel.Junior, HourlyRate = 20, WorkingHours = 120 },
                new DeveloperReport { Id = 3, Name = "Dev3", Level = DeveloperLevel.Senior, HourlyRate = 32.5, WorkingHours = 130 },
                new DeveloperReport { Id = 4, Name = "Dev4", Level = DeveloperLevel.Junior, HourlyRate = 24.5, WorkingHours = 140 }
            };

            
            //Calcualte Total billing amount for all Junior Developer 
            var salaryCalculator = new BillingCalculator(new JuniorDevBillingCalculator());
            double juniorTotal = salaryCalculator.Calculate(reports);
            Console.WriteLine($"Total amount for junior salaries is: {juniorTotal}");

            //Calcualte Total billing amount for all Senior Developer 
            salaryCalculator.SetCalculator(new SeniorDevBillingCalculator());
            var seniorTotal = salaryCalculator.Calculate(reports);
            Console.WriteLine($"Total amount for senior salaries is: {seniorTotal}");

            //Total Bill Amount
            Console.WriteLine($"Total cost for all the salaries is: {juniorTotal + seniorTotal}");

        }
    }
}
