using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write First number");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write Second number");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("First + Second = {0}", value1 + value2);
        }
    }
}
