using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b, s, V;
            Console.Write("Length: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            s = double.Parse(Console.ReadLine());
            V = (a*b*s) / 3;
            Console.WriteLine($"Pyramid Volume: {V}");
            Console.ReadLine();
        }
    }
}
