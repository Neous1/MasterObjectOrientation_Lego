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
    class Man : GeneralObject
    {
        public Man()
        {
            
        }

        public string name { get; set; }
    }

    public class Human
    {
        public Human()
        {
            
        }

        public string name { get; set; }
    }
    public class Woman : GeneralObject 
    {
        public Woman()
        {
            
        }
        
    }

    class Kart : GeneralObject
    {
        public Kart()
        {

        }
        public string manufacturer { get; set; }
    }

    class Alien : GeneralObject
    {
        public Alien()
        {

        }
        public string planet { get; set; }
    }

}
class Program
    {
        static void Main(string[] args)
        {
            var man = new Man();
            var kart = new Kart();
            var alien = new Alien();

        }
    }
}
