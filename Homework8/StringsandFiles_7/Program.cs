using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsandFiles_7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader read = new StreamReader("file.txt"))
            {
                using (StreamWriter write1 = new StreamWriter("nechetno.txt"))
                {
                    using (StreamWriter write2 = new StreamWriter("chetno.txt"))
                    {
                        int count = 0;
                        string line = read.ReadLine();
                        write1.WriteLine(line);
                        while (line != null)
                        {
                            line = read.ReadLine();
                            if (count % 2 == 0)
                            {
                                write2.WriteLine(line);
                            }
                            else write1.WriteLine(line);
                            count++;
                        }
                    }
                }
            }


        }
    }
}
