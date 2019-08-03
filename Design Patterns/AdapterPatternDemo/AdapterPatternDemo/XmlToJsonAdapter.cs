using System;
using System.Linq;
using AdapterPatternDemo.ExistingCode;

namespace AdapterPatternDemo
{
    public class XmlToJsonAdapter : IXmlToJson
    {
        private readonly XmlConverter _xmlConverter;

        public XmlToJsonAdapter(XmlConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }

        public void ConvertXmlToJson()
        {
            var manufacturers = _xmlConverter.GetXml()
                .Element("Manufacturers")
                ?.Elements("Manufacturer")
                .Select(m => new Manufacturer
                {
                    City = m.Attribute("City")?.Value,
                    Name = m.Attribute("Name")?.Value,
                    Year = Convert.ToInt32(m.Attribute("Year")?.Value)
                });

            new JsonConverter(manufacturers)
                .ConvertToJson();
        }
    }
}