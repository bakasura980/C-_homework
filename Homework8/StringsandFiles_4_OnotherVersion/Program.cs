using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsandFiles_4_OnotherVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишете текст");
            string text = Console.ReadLine();
            Console.WriteLine("Въведете дума");
            string word = Console.ReadLine();
            string substring;
            int count = 0;
            if (!text.EndsWith("."))
            {
                text += '.';
            }
            foreach (var item in text)
            {
                if (item == '.' || item == '!' || item == '?')
                {
                    count++;
                }
            }
            for (int i = 0; i < count; i++)
            {
                substring = text.Substring(text.IndexOf(""), text.IndexOf(".") + 1);
                if (substring.Contains(word))
                {
                    Console.WriteLine(substring);
                }
                text = text.Remove(text.IndexOf(""), text.IndexOf(".") + 1);
            }
        }
    }
}
