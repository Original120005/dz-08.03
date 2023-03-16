using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace dz08_03
{
    class Device
    {
        public string name { get; set; }
        public string company { get; set; }
        public int price { get; set; }

        public Device() { }
        public Device(string name, string company, int price)
        {
            this.name = name;
            this.company = company;
            this.price = price;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Device> device1 = new List<Device>()
            {
                new Device("dsf", "Lenovo", 550),
                new Device("iPhone 7", "Apple", 1050),
                new Device("abo", "Meizu", 230),
                new Device("Iphone 11 pro", "Apple", 700),
                new Device("U1223", "Nokia", 380),
                new Device("sour", "Xiaomi", 850)
            };

            var DeviceGroups = from dev in device1
                               group dev by dev.company;
            foreach (IGrouping<string, Device> d in DeviceGroups)
            {
                Console.WriteLine($"{d.Key}:");
                foreach (var a in d)
                {
                    Console.WriteLine(a.name);
                }
                Console.WriteLine();
            }


        }
    }
}
