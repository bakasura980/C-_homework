using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a Real number");
            double value1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Write a Full number");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Their quotient is :");
            Console.WriteLine(value1/value2);
        }
    }
}
