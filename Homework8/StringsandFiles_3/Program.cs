using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsandFiles_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишете текст");
            string text = Console.ReadLine();
            Console.WriteLine("Напишете дума");
            string word = Console.ReadLine();
            string[] text1 = text.Split(' ');
            int count = 0;
            foreach (var item in text1)
            {
                if (word == item)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
