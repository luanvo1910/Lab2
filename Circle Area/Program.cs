using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, s;
            Console.Write("Enter r:");
            r = double.Parse(Console.ReadLine());
            s = 3.1416 * r * r;
            Console.WriteLine($"S = {s:F12}");
            Console.ReadLine();
        }
    }
}
