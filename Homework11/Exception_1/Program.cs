using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename1 = "file1.txt", filename2 = "file2.txt", returnresult;
            try
            {
                returnresult = TakeFileNameReturnString(filename1);
                WriteStringInFile(filename2, returnresult);
            }
            catch (FileDoesnotExistExcpresion filenotexist)
            {
                Console.WriteLine(filenotexist.Message);
            }
            catch (EmptyFileException emptyex)
            {
                Console.WriteLine(emptyex.Message);
            }
        }

        public static string TakeFileNameReturnString(string filename)
        {
            string returnstring;
            if (!File.Exists(filename))
	        {
                throw new FileDoesnotExistExcpresion("File does not exist yet, please create [file1.txt]");
            }else
	        {
                 using (StreamReader reader = new StreamReader(filename))
            {
                if (new FileInfo("file1.txt").Length == 0)
                {
                    throw new EmptyFileException("File is empty");
                }
                else
                {
                    returnstring = reader.ReadToEnd();
                }
            }
            return returnstring;
            }
        }

        public static void WriteStringInFile(string filename, string inputinfile)
        {
            using (StreamWriter write = new StreamWriter(filename, true))
            {
                write.WriteLine(inputinfile);
            }
        }
    }
}
