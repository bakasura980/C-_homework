using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1, value2, counter, i, sum;
            string faktorial_N , faktorial_K;
            long [] arr = new long [3];
            int [] count1 = new int [3];

          do
            {
                Console.WriteLine("Напишете N");
                faktorial_N = Console.ReadLine();
                count1[0] = int.Parse(faktorial_N);
                Console.WriteLine("Напишете K");
                faktorial_K = Console.ReadLine();
                count1[1] = int.Parse(faktorial_K);
            } while (count1[1] <= 1 || count1[0] < count1[1]);

            count1[2] = count1[0] - count1[1];
            if (count1[2] == 0 || count1[2] == 1)
            {
                arr[2] = 1;
                for (counter = 0; counter < 2; counter++)
                {
                    value2 = 0;
                    sum = 1;
                    do
                    {
                        i = count1[counter];
                        value1 = i - value2;
                        sum = sum * value1;
                        value2 = value2 + 1;
                    } while (value2 != count1[counter] - 1);

                    arr[counter] = sum;
                }
            }
            else
            {
                for (counter = 0; counter < 3; counter++)
                {
                    value2 = 0;
                    sum = 1;
                    do
                    {
                        i = count1[counter];
                        value1 = i - value2;
                        sum = sum * value1;
                        value2 = value2 + 1;
                    } while (value2 != count1[counter] - 1);

                    arr[counter] = sum;
                }
            }

            Console.WriteLine("Вашият резултат от (N!*K!)/(N-K)!");
            Console.WriteLine((arr[0] * arr[1]) / arr[2]);
        }
    }
}
