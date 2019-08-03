using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    /// <summary>
    /// http://gyanendushekhar.com/2016/07/16/builder-design-pattern-c/
    /// https://exceptionnotfound.net/builder-the-daily-design-pattern/
    /// Type: Creational
    ///
    /// Design Principle - SRP - as we maintain Concrete Builder class
    ///
    /// The Builder pattern separates the construction of an object from its representation so that the same construction process can create different representations.
    ///
    /// The general idea is that the order in which things happen when an object is instantiated will be the same, but the actual details of those steps change based upon what the concrete implementation is.
    ///
    /// Builder design pattern separates the complex object construction from its representation. It builds the complex object using some construction logic. This construction logic is implemented with step by step process. With different construction logic, different complex objects will be created.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // create object of manufacturer
            var laptopManufacturer = new LaptopManufacturer();
            
            // build Gaming Laptop
            ILaptopBuilder gamingLaptopBuilder = new GamingLaptopBuilder();
            laptopManufacturer.BuildLaptop(gamingLaptopBuilder);
            Laptop gamingLaptop = gamingLaptopBuilder.GetLaptop();
            
            // print details
            Console.WriteLine("\nGaming Laptop Object:");
            gamingLaptop.PrintDetails();

            // build Basic laptop
            ILaptopBuilder basicLaptopBuilder = new BasicLaptopBuilder();
            laptopManufacturer.BuildLaptop(basicLaptopBuilder);
            Laptop basicLaptop = basicLaptopBuilder.GetLaptop();
            
            // print details
            Console.WriteLine("\n\nBasic Laptop Object:");
            basicLaptop.PrintDetails();

            Console.ReadLine();
        }
    }
}
