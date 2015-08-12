using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_objects_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете първия катет");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете втория катет");
            double b = double.Parse(Console.ReadLine());
            int c = 0;
            Triangle_90 value = new Triangle_90(a, b , c);
            value.Hipo();
            value.Ygli();
        }
    }
}
