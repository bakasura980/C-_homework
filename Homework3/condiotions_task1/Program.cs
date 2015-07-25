using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditions_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишете променлива");
            int value1;
            string hate_value = Console.ReadLine();
            double value2;
                       
            bool try1 = Int32.TryParse(hate_value, out value1);
            bool try2 = Double.TryParse(hate_value, out value2);
            if (try1 == true)
            {
                value1 = int.Parse(hate_value);
                value1++;
                Console.WriteLine(value1);
            }else 
            {
             if (try2 == true)
             {
                 value2 = double.Parse(hate_value);
                 value2++;
                 Console.WriteLine(value2);
             } 
                else
            {
                Console.WriteLine(hate_value + "*");
            }
            }
           

        }
    }
}
