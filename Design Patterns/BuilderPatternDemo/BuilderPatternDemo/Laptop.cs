using System;

namespace BuilderPatternDemo
{
    /// <summary>
    /// Product class
    /// </summary>
    class Laptop
    {
        public string ModelNumber { get; set; }
        public string Display { get; set; }
        public string Ram { get; set; }
        public string GraphicsCard { get; set; }
        public string TouchScreen { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine("----------- Laptop Details ----------------");
            Console.WriteLine("Model Number: {0}", ModelNumber);
            Console.WriteLine("Display: {0}", Display);
            Console.WriteLine("RAM: {0}", Ram);
            Console.WriteLine("Graphics Card: {0}", GraphicsCard);
            Console.WriteLine("Touch Screen: {0}", TouchScreen);
        }
    }
}