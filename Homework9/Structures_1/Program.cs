using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете ЕNTER , за да завършите с въвеждането");
            List<int> value = new List<int>();
            string value1;
            do
            {
                value1 = Console.ReadLine();
                if (value1 != string.Empty)
                {
                    if (int.Parse(value1) > 0)
                    {
                        value.Add(int.Parse(value1));
                    }
                    else
                    {
                        Console.WriteLine("Отрицателно число,моля въведете положително");
                    }

                }
            } while (value1 != string.Empty);
            int sum = 0;
            double aritm;
            for (int i = 0; i < value.Count; i++)
            {
                sum += value[i];
            }
            aritm = sum / value.Count;
            Console.WriteLine(sum);
            Console.WriteLine(aritm);
        }
    }
}
