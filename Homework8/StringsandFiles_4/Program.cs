using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsandFiles_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишете текст");
            string text = Console.ReadLine();
            Console.WriteLine("Въведете дума");
            string word = Console.ReadLine();
            string[] arrtext = new string[text.Length];
            StringBuilder value = new StringBuilder();
            int i = 0;
            if (!text.EndsWith("."))
            {
                text += '.';
            }


            foreach (var item in text)
            {
                if (item == '.' || item == '!' || item == '?')
                {
                    value.Append(item);
                    arrtext[i] = value.ToString();
                    value.Clear();
                    i++;
                }
                else
                {
                    value.Append(item);
                }
            }
            for (int j = 0; j < i; j++)
            {
                if (arrtext[j].Contains(word))
                {
                    Console.Write(arrtext[j]);
                }
            }
            Console.WriteLine();
        }
    }
}
