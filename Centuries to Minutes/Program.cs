using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int century;
            decimal year, day, hour, minute;
            Console.Write("Century: ");
            century = int.Parse(Console.ReadLine());
            year = century * 100;
            day = century * 36524;
            hour = day * 24;
            minute = hour * 60;
            Console.WriteLine($"{century} Centyries = {year} Years = {day} Days = {hour} Hours = {minute} Minutes");
            Console.ReadLine();
        }
    }
}
