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
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double energy1 = (energy / 100) * volume;
            double sugar1 = (sugar / 100) * volume;

            Console.WriteLine("{0}ml {1}:" + System.Environment.NewLine + "{2}kcal, {3}g sugars", volume, name, energy1, sugar1);

        }
    }
}
