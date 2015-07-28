using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете големина на масив");
            int value1 = int.Parse(Console.ReadLine());
            int[] arr = new int[value1 + 1];
            int fibonaci_number1 = 1, fibonaci_number2 = 1, sum = 0, count2;
            
            arr[1] = fibonaci_number1; arr[2] = fibonaci_number2;
            for (count2 = 3; count2 < value1 + 1 ; count2++)
			{
                sum = fibonaci_number1 + fibonaci_number2;
                fibonaci_number1 = fibonaci_number2;
                fibonaci_number2 = sum;
                arr[count2] = sum;
            }
            for (int i = 1; i < value1 + 1; i++)
            {
                Console.WriteLine("Fibonacci number{0} = {1}", i, arr[i]);
            }
        }
    }
} 
