using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            var result = worker.AddNumbers(2, 3);

            Console.WriteLine(result.ToString());
        }
    }

    class FactoryWorker
    {
        public FactoryWorker()
        {
            
        }

        //public TYPE Type { get; set; }

        public int AddNumbers(int num1, int num2)
        {
            var result = num1 + num2;
            return result;
        }
    }
}
