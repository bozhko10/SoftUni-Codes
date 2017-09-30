using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int courses = 0;

            if (n % p > 0)
            {
                courses = (n / p) + 1;
            }
            else if (n % p == 0)
            {
                courses = n / p;
            }
            Console.WriteLine(courses);
        }
    }
}
