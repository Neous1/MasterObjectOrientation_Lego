using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulldozer
{
    class BullDozerClass
    {
        public BullDozerClass(string _color, string _size)
        {
            this.color = _color;
            this.size = _size;
        }
        public string color { get; set; }
        public string size { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dozer = new BullDozerClass("Yellow", "Mini");
           

            Console.WriteLine("Bulldozer is: " + dozer.color);
        }
    }
}
