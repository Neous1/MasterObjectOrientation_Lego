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

    class SaloonCar : Car
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
        }
    }
}
