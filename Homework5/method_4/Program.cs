using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string end = "end";
            do{
            Console.WriteLine("Въведи число");
            int Number = int.Parse(Console.ReadLine());
            Kind_of_Number(ref Number);
            Console.WriteLine("Въведи end , за да излезнеш от програмата,ако искаш да продължиш натисни Enter");
            } while (Console.ReadLine() != end );
            
	
        }

        private static void Kind_of_Number(ref int Number)
        {
            if (Number % 2 == 0)
            {
                Console.WriteLine("Числото е четно");
            }
            else Console.WriteLine("Числото не е четно");
        }
    }
}
