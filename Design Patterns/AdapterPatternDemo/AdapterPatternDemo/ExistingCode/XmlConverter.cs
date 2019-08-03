using System;
using System.Linq;
using System.Xml.Linq;

namespace AdapterPatternDemo.ExistingCode
{
    public class XmlConverter
    {
        public XmlConverter()
        {
            
        }

        public XDocument GetXml()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Manufacturers");
            var xAttributes = ManufacturerDataProvider.GetAllManufacturers()
                .Select(m => new XElement("Manufacturer",
                    new XAttribute("City", m.City),
                    new XAttribute("Name", m.Name),
                    new XAttribute("Year", m.Year)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            Console.WriteLine(xDocument);

            return xDocument;
        }
    }
}