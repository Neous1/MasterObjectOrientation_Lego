using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Bulldozer;

namespace Bulldozer
{
    public class FactoryWorker
    {
        public FactoryWorker()
        {
            
        }

        public void Count(int number)
        {
            if (Total == null)
                Total = 0;

            Total += Convert.ToSingle(number);
            Console.WriteLine(Total.ToString());
        }

        public void Count(float number)
        {
            Total += number;
            Console.WriteLine(Total.ToString());
        }
        //method overload


        public float Total { get; set; }

    } 
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            worker.Count(4);
            worker.Count(5);
            worker.Count(4.5f);

        }
    }
}


