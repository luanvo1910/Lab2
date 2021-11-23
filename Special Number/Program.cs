using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i ++)
            {
                int a, b, c, sum;
                a = i / 100;
                b = (i % 100) / 10;
                c = i % 10;
                sum = a + b + c;
                if (sum == 5 || sum == 7 ||sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
            Console.ReadLine();
        }
    }
}
