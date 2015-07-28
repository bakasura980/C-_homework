using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете големината на масива");
            int value1 = int.Parse(Console.ReadLine());
            int i,j,value3 = 0;
            int[] arr = new int [value1];
            for (i = 0; i < value1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Въведете търсено число");
            int value2 = int.Parse(Console.ReadLine());
            for (j = 0; j < value1; j++)
            {
                if (arr[j] == value2)
                {
                    Console.WriteLine("Индексът на търсеното от вас число {0} := {1}", value2, j);
                    break;
                }
                else value3++;
            }
            if (value3 == value1)
            {
                Console.WriteLine("Няма намерен индекс");
            }
          
        }
    }
}
