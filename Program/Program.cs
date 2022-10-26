using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllText("data.json");
            var listOfPublishers = JsonConvert.DeserializeObject<List<Publisher>>(file);
            
            foreach (var publisher in listOfPublishers)
            {
                publisher.Print();
            }
            Console.ReadKey();
        }
    }
}
