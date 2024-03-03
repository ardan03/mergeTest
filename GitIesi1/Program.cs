using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIesi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            //S1REN код
            Console.WriteLine($"{a}+{b}");
            Console.WriteLine($"{a}-{b}");
            Console.WriteLine($"{a}*{b}");
        }
    }
}
