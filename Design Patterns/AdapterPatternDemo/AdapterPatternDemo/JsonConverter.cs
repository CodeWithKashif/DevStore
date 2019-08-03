using System;
using System.Collections.Generic;
using AdapterPatternDemo.ExistingCode;
using Newtonsoft.Json;

namespace AdapterPatternDemo
{
    public class JsonConverter
    {
        private readonly IEnumerable<Manufacturer> _manufacturers;

        public JsonConverter(IEnumerable<Manufacturer> manufacturers)
        {
            _manufacturers = manufacturers;
        }

        public void ConvertToJson()
        {
            var jsonManufacturers = JsonConvert.SerializeObject(_manufacturers, Newtonsoft.Json.Formatting.Indented);
            
            Console.WriteLine("\nPrinting JSON list\n");
            Console.WriteLine(jsonManufacturers);
        }
    }
}