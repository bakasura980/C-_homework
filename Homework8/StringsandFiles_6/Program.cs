using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsandFiles_6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader read = new StreamReader("with.txt"))
            {
                using (StreamWriter write = new StreamWriter("without.txt"))
                {
                    string line = read.ReadLine();
                    StringBuilder value = new StringBuilder();
                    string[] lines = line.Split('.', ',', ';', '!', '?');
                    foreach (var item in lines)
                    {
                        value.Append(item);
                    }
                    write.WriteLine(value);
                    value.Clear();
                    string text = read.ReadToEnd();
                    string[] lines1 = text.Split('.', ',', ';', '!', '?');
                    foreach (var item in lines1)
                    {
                        value.Append(item);
                    }
                    write.Write(value);
                }
            }
        }
    }
}
