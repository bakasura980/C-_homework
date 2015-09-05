using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете бройката на числата,които ще напишете");
            int[] arr = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
