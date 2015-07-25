using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишете число до,което да се изкарват всички числа,които не се делят на 3 и 7");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 1; i < (n + 1); i++)
            {
                
                if (i % 3 != 0 || i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
