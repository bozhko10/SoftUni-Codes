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
            string name = Console.ReadLine();
            int healthNOW = int.Parse(Console.ReadLine());
            int healthMAX = int.Parse(Console.ReadLine());
            int energyNOW = int.Parse(Console.ReadLine());
            int energyMAX = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}" + System.Environment.NewLine + "Health: |{1}{2}|" + System.Environment.NewLine + "Energy: |{3}{4}|",
                name,
                new string('|', healthNOW), new string('.', healthMAX - healthNOW),
                new string('|', energyNOW), new string('.', energyMAX - energyNOW)
                );
        }
    }
}
