using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class SerializeDeserialize
    {
        public string Serialization<T>(T langauges)
        {
            string json = JsonConvert.SerializeObject(langauges);

            Console.WriteLine(json);

            return json;
        }
        public T DeSerialization<T>(string json)
        {
            T langauges = JsonConvert.DeserializeObject<T>(json);

            return langauges;

        }
    }
}
