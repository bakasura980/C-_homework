using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, k;
            int value1, value2 = 0;

            do
            {
                Console.WriteLine("Въведете големина на масива");
                value1 = int.Parse(Console.ReadLine());
            } while (value1 < 1 || value1 > 100);

            int[] arr = new int[value1 + 1];
            
            for (j = 0; j < value1; j++)
            {
                arr[j] = int.Parse(Console.ReadLine());
            }

            int sum = 1, sum1 = 1;
            
            for (k = 0; k < value1; k++)
			{
			  for (j = k + 1 ; j < value1 ; j++)
              {
                    if (arr[k] == arr[j])
                    {
                        sum++;
                    }
              }

              if (sum > sum1)
              {
                  sum1 = sum;
                  value2 = arr[k];
              }
              sum = 1;
              if (k == value1 - 1) break;
			}
            if (sum1 != 1)
            {
                Console.WriteLine("Числото {0} се среща - {1} пъти", value2, sum1);
            }else 
            Console.WriteLine("Всички числа се повтарят по веднъж");
        }
    }
}
