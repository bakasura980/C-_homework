using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_8_full_version
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишете число : ");
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[n, n];
            int row = 0;
            int col = -1;
            int count = 1;
            int step = n;
            int direction = 1;

            while (count <= n * n)
            {
                if (direction == 1)
                {
                    for (int k = 0; k < step; k++)
                    {
                        col++;
                        array[row, col] = count;
                        count++;
                    }
                    direction = 2;
                    step--;
                }

                if (direction == 2)
                {
                    for (int k = 0; k < step; k++)
                    {
                        row++;
                        array[row, col] = count;
                        count++;
                    }
                    direction = 3;
                }

                if (direction == 3)
                {
                    for (int k = 0; k < step; k++)
                    {
                        col--;
                        array[row, col] = count;
                        count++;
                    }
                    direction = 4;
                    step--;
                }

                if (direction == 4)
                {
                    for (int k = 0; k < step; k++)
                    {
                        row--;
                        array[row, col] = count;
                        count++;
                    }
                    direction = 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
        
}
            
        
        
    