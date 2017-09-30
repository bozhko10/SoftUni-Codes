using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {

                int sum = (i % 10) + (i - (i % 10));

                switch (sum)
                {
                    case 5:
                    case 7:
                    case 11: Console.WriteLine("{0} -> True", sum);break;
                    default: Console.WriteLine("{0} -> False", sum); break;
                }
            }
        }
    }
}

