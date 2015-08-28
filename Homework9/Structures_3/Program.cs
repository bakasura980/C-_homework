using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_3
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
                    if (int.Parse(value1) > -1 && int.Parse(value1) < 1001)
                    {
                        value.Add(int.Parse(value1));
                    }
                }
            } while (value1 != string.Empty);
            value.Sort();
            int j = 0, count = 0;
            for (int i = 0; i < value.Count; i++)
            {
                
                if (value[j] == value[i])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1} пъти", value[j] , count);
                    j = i;
                    count = 1;
                }
            }
            Console.WriteLine("{0} -> {1} пъти", value[j], count);
        }
    }
}
