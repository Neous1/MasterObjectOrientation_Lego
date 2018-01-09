using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Bulldozer;

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

    public class GeneralObject
    {
        public GeneralObject()
        {
            
        }

        public bool moves { get; set; }    
        public string color { get; set; }
    }
    class Man
    {
        public Man()
        {
            
        }

        public bool moves { get; set; }
        public string name { get; set; }
        public string color { get; set; }
    }

    class Kart
    {
        public Kart()
        {

        }
        public bool moves { get; set; }
        public string manufacturer { get; set; }
        public string color { get; set; }
    }

    class Alien
    {
        public Alien()
        {

        }
        public bool moves { get; set; }
        public string planet { get; set; }
        public string color { get; set; }
    }

}
class Program
    {
        static void Main(string[] args)
        {
            var dozer = new BullDozerClass("Yellow", "Mini");
            var dozer2 = new BullDozerClass("Red", "Large");
           
    
            Console.WriteLine("Bulldozer 1  is: " + dozer.color);
            Console.WriteLine("Bulldozer 2 is: " + dozer2.color);
            Console.WriteLine();
        }
    }
}
