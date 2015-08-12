using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_objects_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете градуси целзии");
            double celzii = double.Parse(Console.ReadLine());
            ConvertCelzii value = new ConvertCelzii(celzii);
            Console.WriteLine("Фаренхайт - {0}", value.Convertion);
        }
    }
}
