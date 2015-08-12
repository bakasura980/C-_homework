using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_objects_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] value = new Car[11];
            int cost, fuel_auto;
            string yes_or_not;
            bool off4x4;
            Console.WriteLine("Коли");
            Console.WriteLine();
            for (int i = 1; i < 6; i++)
            {
                
                    Console.WriteLine("Въведете цена на автоомобил {0}", i);
                    cost = int.Parse(Console.ReadLine());
                    Console.WriteLine("Въведете разход на гориво :");
                    fuel_auto = int.Parse(Console.ReadLine());
                    Console.WriteLine("Автомобил {0}", i);
                    value[i] = new Automobile(cost, fuel_auto);
              
            }
            Console.WriteLine();
            Console.WriteLine("Джипов");
            Console.WriteLine();
            for (int i  = 1; i < 6; i++)
			{
			        Console.WriteLine("Въведете цена на джип {0}", i);
                    cost = int.Parse(Console.ReadLine());
                    Console.WriteLine("Високопроходим ли е ?:");
                    yes_or_not = Console.ReadLine();
                    if (yes_or_not == "Yes")
                    {
                        off4x4 = true;
                    }
                    else off4x4 = false;
                    Console.WriteLine("Джип {0}", i);
                    value[i] = new SUV(cost, off4x4);
			}
                    
        }
            
            
           
    }
}

