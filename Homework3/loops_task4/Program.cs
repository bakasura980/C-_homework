using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum, value1, value2, i, j;
            int[] arr = new int[2];
            int[] count1 = new int [2];
            string faktorial_K, faktorial_N;
            do
            {
                Console.WriteLine("Напишете N");
                faktorial_N = Console.ReadLine();
                count1[0] = int.Parse(faktorial_N);
                Console.WriteLine("Напишете K");
                faktorial_K = Console.ReadLine();
                count1[1] = int.Parse(faktorial_K);

            } while (count1[1] <= 1 || count1[0] <= count1[1]);

            for (j = 0; j < 2; j++)
            {
                value2 = 0;
                sum = 1;
                do
                {
                    i = count1[j];
                    value1 = i - value2;
                    sum = sum * value1;
                    value2 = value2 + 1;
                } while (value2 != count1[j] - 1);
                
                arr[j] = sum;
            }
            Console.WriteLine("Вашият резултат от делението на факториалите е :");
            Console.WriteLine(arr[0]/arr[1]);
        }
    }
}
