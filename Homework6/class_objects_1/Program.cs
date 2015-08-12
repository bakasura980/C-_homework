using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_objects_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arr = new string[10,10];
            int j, i;
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("Name : ");               
                for (j = 0; j < 2; j++)
                {
                    if (j == 1)
                        Console.WriteLine("Age : ");
                    arr[i, j] = Console.ReadLine();
                }
            }
            string name, age;
            Console.WriteLine("Method Say() : ");
            for (int k = 0; k < 2; k++)
            {
                j = 0;
                name = arr[k,j];
                age = arr[k, j + 1];
                Cat value = new Cat(name,age);
                value.Say();
            }
        }
    }
}
