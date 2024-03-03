using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIesi1
{
    internal class Program
    {
        public static int addgition(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            //iKuta код
            Console.WriteLine(addgition(a,b));
        }
    }
}
