using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, p, x;
            Console.Write("Enter of people: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter course capacity: ");
            p = int.Parse(Console.ReadLine());
            if (n%p==0)
            {
                x = n / p;
                Console.WriteLine($"Course: {x}");
            }
            else
            {
                x = (n / p) + 1;
                Console.WriteLine($"Course: {x}");
            }
            Console.ReadLine();
        }
    }
}
