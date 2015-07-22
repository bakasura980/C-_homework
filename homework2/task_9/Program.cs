using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your string");
            string value1 = Console.ReadLine();
            Console.WriteLine("Write the number of the letter, that you are locking for");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Your result is : {0}", value1[value2]);
        }
    }
}
