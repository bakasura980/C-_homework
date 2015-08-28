using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете текст");
            string text = Console.ReadLine();
            string[] arr = text.Split(' ');
            HashSet<string> hesh = new HashSet<string>(arr);
            string[] arr1 = hesh.ToArray();
            Console.WriteLine(string.Join(",", arr1));
        }
    }
}
