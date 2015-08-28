using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_2
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
                    
                        value.Add(int.Parse(value1));
                    
                }
            } while (value1 != string.Empty);
            int count = 0;
            List<int> value2 = new List<int>();
            for (int i = 0; i < value.Count; i++)
            {
                for (int j = 0; j < value.Count; j++)
                {
                    if (value[i] == value[j])
                    {
                        count++;
                    }
                }
                if (count % 2 != 0)
                {
                    if (!value2.Contains(value[i]))
                    {
                        value2.Add(value[i]);
                    }
                }
                count = 0;
            }
            for (int i = 0; i < value2.Count; i++)
            {
                value.RemoveAll(item => item == value2[i]);
            }
            for (int i = 0; i < value.Count; i++)
            {
                Console.WriteLine(value[i]);
            }
        }
    }
}
