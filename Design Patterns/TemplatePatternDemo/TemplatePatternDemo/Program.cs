using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternDemo
{
    /// <summary>
    /// https://exceptionnotfound.net/the-daily-design-pattern-template-method/
    /// Template Method pattern defines in what order certain steps should occur, but can optionally leave the specific details of those steps to be implemented by other classes
    ///
    /// Type: Behavioral
    /// 
    /// Good For: Creating an outline of an algorithm but letting specific steps be implemented by other classes.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Sourdough sourdough = new Sourdough();
            sourdough.Make();

            Console.WriteLine("\n--------------------------------\n");
            TwelveGrain twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            Console.WriteLine("\n--------------------------------\n");
            WholeWheat wholeWheat = new WholeWheat();
            wholeWheat.Make();

            Console.ReadKey();
        }
    }
}
