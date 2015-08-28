using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type ENTER to stop inserting");
            List<int> arr = new List<int>();
            string number;
            do
            {
                number = Console.ReadLine();
                try
                {
                    arr.Add(int.Parse(number));
                }
                catch (Exception)
                {
                    number = string.Empty;   
                }
            } while (number != string.Empty);
            int search = arr.Count / 2 + 1, counter;
            for (int i = 0; i < arr.Count; i++)
            {
                counter = 0;
                if (arr[i] == Convert.ToInt32(true))
                {
                    continue;
                }
                for (int j = 0; j < arr.Count; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        if (i != j)
                        {
                            arr[j] = Convert.ToInt32(true);
                        }
                        counter++;
                    }
                }
                if (counter == search)
                {
                    Console.WriteLine(arr[i]);
                    break;
                }
                if (arr[i] == arr.Count-1)
                {
                    Console.WriteLine("Majorant does not exist");
                }
            }
        }
    }
}
