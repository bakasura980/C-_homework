using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_5
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSymetircNumbers();
        }

        private static void PrintSymetircNumbers()
        {
            int j = 1;
            for (int i = 10; i < 1000; i++)
            {
                if (i < 100)
                {
                    if (i / 10 == i % 10)
                    {
                        Console.WriteLine(i);
                    }
                }
                
                else
                {
                    
                    if (i > 100 && i < 1000)
                    {
                        
                        
                        if ((i / 100 - (i/100 - j)) == i % 10)
                        {
                            Console.WriteLine(i);
                            j = i / 100;
                        }
                        
                        
                    }
                    
                }
               
            }
            
        }
    }
}
