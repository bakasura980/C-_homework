using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишете колко числа искате да въведете:");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете числата");
            int i;
            int[] value2 = new int[value1];
            for (i = 0; i < value1; i++)
            {
                value2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Най-голямото число е :");
            Console.WriteLine(value2.Max());
            Console.WriteLine("Най-малкото число е :");
            Console.WriteLine(value2.Min());
        }
    }
}
