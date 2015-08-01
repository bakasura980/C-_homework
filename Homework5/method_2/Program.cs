using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = Console.ReadLine();
            Console.WriteLine("Greetings, {0} !", PrintName(ref value1));
            
        }

        private static string PrintName(ref string value1)
        {
            return value1;   
        }
    }
}
