using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulldozer
{
    class BullDozerClass
    {
        public string color { get; set; }
        public string size { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dozer = new BullDozerClass();
            dozer.color = "Yellow";
            dozer.size = "Mini";

            Console.WriteLine("Bulldozer is: " + dozer.color);
        }
    }
}
