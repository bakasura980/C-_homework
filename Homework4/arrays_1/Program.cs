using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете брой на елементи");
            int value1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[value1];
            int i, sum = 0;
            for (i = 0; i < value1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                if (arr1[i] % 2 == 0)
                {
                    sum += arr1[i];
                }
            }
            if (sum == 0)
            {
                Console.WriteLine("Няма четни елементи");
            }
            else
            {
                Console.WriteLine("Сумата от четните елементи :");
                Console.WriteLine(sum);
            }
        }
    }
}
