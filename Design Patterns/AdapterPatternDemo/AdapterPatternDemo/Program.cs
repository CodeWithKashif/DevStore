using AdapterPatternDemo.ExistingCode;
using System;

namespace AdapterPatternDemo
{
    /// <summary>
    /// https://code-maze.com/adapter/
    ///
    /// Design principle - OCP - as it doesnt want to change the existing code base for whatever reason
    /// 
    /// We should use the Adapter class whenever we want to work with the existing class but its interface is not compatible with the rest of our code. Basically, the Adapter pattern is a middle-layer which serves as a translator between the code implemented in our project and some third party class or any other class with a different interface.
    /// Furthermore, we should use the Adapter when we want to reuse existing classes from our project but they lack a common functionality.By using the Adapter pattern in this case, we don’t need to extend each class separately and create a redundant code.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var xmlConverter = new XmlConverter();
            xmlConverter.GetXml();

            Console.WriteLine("\n\n --------------After new implementation-----------------\n");

            var xmlConverter2 = new XmlConverter();
            IXmlToJson adapter = new XmlToJsonAdapter(xmlConverter2);
            adapter.ConvertXmlToJson();
            
            Console.ReadKey();
        }
    }
}
