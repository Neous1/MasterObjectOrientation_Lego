﻿using System;
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
            var dozer2 = new BullDozerClass("Red", "Large");
           
    
            Console.WriteLine("Bulldozer 1  is: " + dozer.color);
            Console.WriteLine("Bulldozer 2 is: " + dozer2.color);
            Console.WriteLine();
        }
    }
}
