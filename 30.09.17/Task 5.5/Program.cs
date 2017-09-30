using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                int sum = 0;
                int number = i;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                switch (sum)
                {
                    case 5:
                    case 7:
                    case 11: Console.WriteLine("{0} -> True", i); break;
                    default: Console.WriteLine("{0} -> False", i); break;
                }
            }
        }
    }
}
