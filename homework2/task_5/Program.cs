using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write First number :");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write Second number :");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Result for %(mod) :");
            Console.WriteLine(value1 % value2);
        }
    }
}
