using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditions_task2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Напишете своите точки 1-9");
            int value1 = int.Parse(Console.ReadLine());
            switch (value1) 
            {
                case 1:
                case 2:
                case 3: value1 += 5; break;
                case 4:
                case 5:
                case 6: value1 *= 12; break;
                case 7:
                case 8:
                case 9: value1 *= 50; value1 /= 3; break;            
            }
            Console.WriteLine(value1);
        }
    }
}
