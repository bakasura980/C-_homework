using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете дължина на масив 1,2");
            int value1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[value1+1];
            int[] arr2 = new int[value1+1];
            int i, j = 1;
            for (i = 1; i < value1+1; i++)
            {
                Console.WriteLine("Въведете {0} число на масив 1 ",i);
                arr1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Въведете {0} число на масив 2 ",i);
                arr2[i] = int.Parse(Console.ReadLine());
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine("Двата масива не са еднакви");
                    break;
                }
                else j++;
            }
            if (j == value1 + 1)
            {
                Console.WriteLine("Двата масива са еднакви");
            }

        }
    }
}
