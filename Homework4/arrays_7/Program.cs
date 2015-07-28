using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете колко реда да има матрицата");
            int value1 = int.Parse(Console.ReadLine());
            int i, j;
            int[,] arr1 = new int[value1,value1];
            for (i = 0; i < value1; i++)
            {
                for (j = 0; j < value1; j++)
                {
                    arr1[j,i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (i = 0; i < value1; i++)
            {
                for (j = 0; j < value1; j++)
                {
                    Console.Write(arr1[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
