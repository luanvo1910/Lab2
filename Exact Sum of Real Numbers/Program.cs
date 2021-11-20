using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            decimal result = 0;
            Console.Write("Enter number:");
            n = int.Parse(Console.ReadLine());
            for (var i = 0; i<n; i++)
            {
                Console.Write($"Enter {i + 1} number:");
                decimal x = decimal.Parse(Console.ReadLine());
                result += x;
            }
            Console.WriteLine($"{result}");
            Console.Read();
        }
    }
}
