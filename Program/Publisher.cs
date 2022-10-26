using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Program
{
    public class Publisher
    {
       
        public int PublishingHouseId { get; set; } = 0;
        public string Title { get; set; }
        public PublishingHouse PublishingHouse { get; set; }

        public void Print()
        {
            Console.WriteLine($"PublishingHouseId: {PublishingHouseId}");
            Console.WriteLine($"Title: {Title}");
            PublishingHouse.Print();
        }
    }
}
