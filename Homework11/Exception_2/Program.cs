using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = new StreamReader("text.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    try
                    {
                        ChekLine(line);
                    }
                    catch (SentenceNotCompletedException exception)
                    {
                        Console.WriteLine(exception.Message);   
                    }
                }
            }
        }

        public static void ChekLine(string line)
        {
            
            if (line.EndsWith(".") || line.EndsWith("?") || line.EndsWith("!"))
            {
                Console.WriteLine(line);
            }
            else
            {
                throw new SentenceNotCompletedException("Sentence does not end with punctuation mark");
            }
        }
    }
}
