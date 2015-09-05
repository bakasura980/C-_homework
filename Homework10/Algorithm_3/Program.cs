using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишете изречение");
            string text = Console.ReadLine();
            string[] arr = text.Split(' ');
            Array.Sort(arr);
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
