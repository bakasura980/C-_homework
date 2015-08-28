using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> value = new Dictionary<int, string>();
            Console.WriteLine("Въведете ЕNTER , за да завършите с въвеждането");
            string word;
            for (int i = 0; i < 20; i++)
            {
                word = Console.ReadLine();
                value.Add(i, word);
            }
            int count = 0;
            for (int i = 0; i < value.Count; i++)
            {
                if (value[i] == Convert.ToString(true))
                {
                    continue;
                }
                for (int j = 0; j < value.Count; j++)
                {
                    if (value[i] == value[j])
                    {
                        if (i == j)
                        {
                            count++;
                        }
                        else
                        {
                            count++;
                            value[j] = Convert.ToString(true);
                        }
                    }
                }
                Console.WriteLine("Думата {0} -> {1} пъти", value[i],count);
                count = 0;
            }    
        }
    }
}
