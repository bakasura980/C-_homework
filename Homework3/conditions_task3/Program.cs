using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditions_task3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Напишете карта(карта номер 10 = T) :");
            char count1 = char.Parse(Console.ReadLine());

            if (count1 == 'J' || count1 == 'Q' || count1 == 'K' || count1 == 'A' || count1 == 'T')
            {


                Console.WriteLine("Валидна карта");
            }
            else 
            {
                if (count1 >= '1' && count1 <= '9')
                {
                Console.WriteLine("валидна карта");
                }
                else Console.WriteLine("Не валидна карта");
            }
            
        }
    }
}
