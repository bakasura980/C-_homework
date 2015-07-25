using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишете две числа");
            int value1 = int.Parse(Console.ReadLine());
            int value2 = int.Parse(Console.ReadLine());
            int i, sum = 0;
            if (value1 > 0 && value2 > 0)
            {
                for (i = 1; i < value1 + value2; i++)
                {

                    if (value1 % i == 0 && value2 % i == 0)
                    {
                        sum = i;

                    }
                }

            }
            else
            {
                if (value1 < 0 && value2 < 0)
                {
                    for (i = 1; i < (value1 + value2)*-1; i++)
                    {

                        if (value1 % i == 0 && value2 % i == 0)
                        {
                            sum = -i;

                        }
                    }

                }
            }
            Console.WriteLine("Вашият най-голям общ делител е :");
            Console.WriteLine(sum);

        }
    }
}
