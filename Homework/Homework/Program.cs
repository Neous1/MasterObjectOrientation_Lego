using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Car
    {
        public string Colour { get; set; }
        public string Manufacturer { get; set; }

    }

    public class SaloonCar : Car
    {
        public int NumberOfSeats { get; set; }

        public SaloonCar(int numberOfSeats)
        {
            
        }

        public SaloonCar(int numberOfSeats, string manufacturer)
        {
            
        }
        public SaloonCar(int numberOfSeats, string manufacturer, string colour)
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var saloonCar1 = new SaloonCar(numberOfSeats:2);
            var saloonCar2 = new SaloonCar(numberOfSeats:3, manufacturer:"Nissan");
            var saloonCar3 = new SaloonCar(numberOfSeats:4, manufacturer:"Ford", colour:"Purple");

            Console.WriteLine(saloonCar1);
            
        }
    }
}
