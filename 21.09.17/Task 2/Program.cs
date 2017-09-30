using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double weidth = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            
            Console.WriteLine("{0:f2}", weidth * height);
        }
    }
}
