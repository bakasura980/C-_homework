using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsandFiles_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder value = new StringBuilder();
            Console.WriteLine("Въведете дума");
            string word = Console.ReadLine();
            char[] arr = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                arr[i] = word[i];
            }
            Array.Reverse(arr);
            for (int i = 0; i < word.Length; i++)
            {
                value.Append(arr[i]);
            }
            Console.WriteLine(value);
            Console.WriteLine();
        }
    }
}
