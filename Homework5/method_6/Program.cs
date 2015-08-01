using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_6
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            return n * Factorial(n - 1);
            
          
        }
        static void Main(string[] args)
        {
            
            Console.Write("Напишете число : ");
            int n = int.Parse((Console.ReadLine()));
            int value1 = Factorial(n);
            Console.WriteLine(n + "! = " + value1);
        }
    }
           
    }
