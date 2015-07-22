using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write First side :");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write Second side :");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The facing is : {0} ", value1*value2);
        }
    }
}
