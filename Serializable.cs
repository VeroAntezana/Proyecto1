using System;

using Newtonsoft.Json;
using System.IO;

namespace Proyecto1_01
{
    class Serializable
    {
      
        public static void Serialize(object obj, string path)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter(path))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, obj);
                }
            }
        }
        public static object Deserialize(string path)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamReader(path))
            using (var reader = new JsonTextReader(sw))
            {
                return serializer.Deserialize(reader);
            }
        }

        /*static void Main(string[] args)
        {
            var Cubo = new Proyecto1_01.Cubo(,10,10,10);

            Console.WriteLine("-------Objeto antes del cambio----------");

            Console.WriteLine(Deserialize("json.json").ToString());

            Serialize(Cubo, "json.json");

            Console.WriteLine("-------Objeto después del cambio----------");

            Console.WriteLine(Deserialize("json.json").ToString());

            Console.ReadLine();
        }*/
    }
}
