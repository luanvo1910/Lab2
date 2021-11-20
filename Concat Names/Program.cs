using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c;
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            string d = a + c + b;
            Console.WriteLine($"Name: {d}");
            Console.ReadLine();
        }
    }
}
