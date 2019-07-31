using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    /// <summary>
    /// https://exceptionnotfound.net/decorator-the-daily-design-pattern/
    /// The Decorator design pattern seeks to add new functionality to an existing object without
    /// changing that object's definition.
    ///
    /// In other words, it wants to add new responsibilities to an individual instance, without
    /// adding those responsibilities to the class of objects.
    /// Decorator can be thought of as an alternative to inheritance.
    ///
    /// It also called an implimentation of OCP design principle
    /// </summary>
    ///
    
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1: Define some dishes, and how many of each we can make
            var caesarSalad = new FreshSalad(greens:"Crisp romaine lettuce", cheese:"Freshly-grated Parmesan cheese", dressing:"House-made Caesar dressing");
            caesarSalad.Display();

            var fettuccineAlfredo = new Pasta(pastaType:"Fresh-made daily pasta", sauce:"Creamly garlic alfredo sauce");
            fettuccineAlfredo.Display();

            Console.WriteLine("\nMaking these dishes available.");


            //Step 2: Decorate the dishes;
            //now if we attempt to order them once we're out of ingredients, we can notify the customer
            var availableCaesar = new AvailableDish(caesarSalad, 3);
            var availableAlfredo = new AvailableDish(fettuccineAlfredo, 4);

            //Step 3: Order a bunch of dishes
            availableCaesar.OrderItem("John");
            availableCaesar.OrderItem("Sally");
            availableCaesar.OrderItem("Manush");

            availableAlfredo.OrderItem("Sally");
            availableAlfredo.OrderItem("Francis");
            availableAlfredo.OrderItem("Venkat");
            availableAlfredo.OrderItem("Diana");

            availableAlfredo.OrderItem("Dennis"); //There won't be enough for this order.

            availableCaesar.Display();
            availableAlfredo.Display();

            Console.ReadKey();
        }
    }
}
