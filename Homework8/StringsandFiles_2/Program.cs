using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsandFiles_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишете дума");
            string word = Console.ReadLine();
            Console.WriteLine("Напишете текст");
            string text = Console.ReadLine();
            text = text.Replace(word, word.ToUpper());
            Console.WriteLine(text);
        }
    }
}
