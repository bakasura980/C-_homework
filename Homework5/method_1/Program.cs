using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Най-голямото число е:");
            Console.WriteLine(MaxNumber(ref a, ref b, ref c));
        }

        private static int MaxNumber(ref int a, ref int b, ref int c)
        {
            if (a > b && b > c)
            {
                return a;
            }
            else if (b > c && b > a)
            {
                return b;
            }
            else if (c > a && c > b) return c; else return 0;
        }
    }
}
