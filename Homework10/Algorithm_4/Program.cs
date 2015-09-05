using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете брой на числата за въвеждане(N)");
            int[] arr = new int[int.Parse(Console.ReadLine())];
            List<int> arr_ch = new List<int>();
            List<int> arr_n = new List<int>();
            Console.WriteLine("Въведете числата : ");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                    if (arr[i] % 2 == 0)
                    {
                        arr_ch.Add(arr[i]);
                    }
                    else
                    {
                        arr_n.Add(arr[i]);
                    }
                }

                Stopwatch watch =  new Stopwatch();
                watch.Start();
                Array.Sort(arr);
                watch.Stop();
                Console.WriteLine("Голям масив : {0}" , watch.Elapsed);
                
                Stopwatch watch1 = new Stopwatch();
                watch1.Start();
                arr_ch.Sort();
                watch1.Stop();
                Console.WriteLine("Четен масив : {0}", watch1.Elapsed);
                
                Stopwatch watch2 = new Stopwatch();
                watch2.Start();
                // Sort + Reverse is faster , than the method "OrderBydescending"
                //arr_n = arr_n.OrderByDescending(x => x).ToList();
                arr_n.Sort();
                arr_n.Reverse();
                watch2.Stop();
                Console.WriteLine("Нечетен масив : {0}", watch2.Elapsed);
            
                Console.WriteLine();

                if (watch1.Elapsed > watch2.Elapsed)
                {
                    if (watch2.Elapsed > watch.Elapsed)
                    {
                        Console.WriteLine("Големият масив е най-бързо сортиран");
                    }
                    else
                    {
                        Console.WriteLine("Нечетният масив е най-бързо сортиран");
                    }
                }
                else
                {
                    if (watch1.Elapsed > watch.Elapsed)
                    {
                         Console.WriteLine("Големият масив е най-бързо сортиран");
                    }
                    else
                    {
                        Console.WriteLine("Четният масив е най-бързо сортиран");
                    }
                }
        }
    }
}
