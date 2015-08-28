using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr1 = new List<int>();
            List<int> arr3 = new List<int>();
            List<int> arr2 = new List<int>();
            int i = 0;
            arr1.Add(1);
            arr2.Add(2);
            arr3.Add(2);
            do
            {
                i++;
                arr1.Add(2 * arr1[i - 1] + 3);
                arr2.Add(3 * arr2[i - 1] + 1);
                arr3.Add(2 * arr3[i - 1] - 1);
            } while (arr3[i] < 100000);
            arr1.RemoveAll(item => item > 100000);
            arr2.RemoveAll(item => item > 100000);
            arr3.RemoveAt(i);
           
            HashSet<int> hesh1 = new HashSet<int>(arr1);
            HashSet<int> hesh2 = new HashSet<int>(arr2);
            HashSet<int> hesh3 = new HashSet<int>(arr3);

            int[] intersect1 = hesh1.Intersect(hesh2).ToArray();
            Console.WriteLine("arr1*arr2");
            foreach (var item in intersect1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            intersect1 = null;
            intersect1 = hesh1.Intersect(hesh3).ToArray();
            Console.WriteLine("arr1*arr3");
            foreach (var item in intersect1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            intersect1 = null;
            intersect1 = hesh2.Intersect(hesh3).ToArray();
            Console.WriteLine("arr2*arr3");
            foreach (var item in intersect1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            intersect1 = null;
            intersect1 = hesh1.Intersect(hesh2).Intersect(hesh3).ToArray();
            Console.WriteLine("arr1*arr2*arr3");
            foreach (var item in intersect1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            int[] union1 = hesh1.Union(hesh2).ToArray();
            Array.Sort(union1);
            Console.WriteLine("arr1+arr2");
            foreach (var item in union1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            union1 = null;
            union1 = hesh1.Union(hesh3).ToArray();
            Array.Sort(union1);
            Console.WriteLine("arr1+arr3");
            foreach (var item in union1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            union1 = null;
            union1 = hesh2.Union(hesh3).ToArray();
            Array.Sort(union1);
            Console.WriteLine("arr2+arr3");
            foreach (var item in union1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            union1 = null;
            union1 = hesh1.Union(hesh2).Union(hesh3).ToArray();
            Array.Sort(union1);
            Console.WriteLine("arr1+arr2+arr3");
            foreach (var item in union1)
            {
                Console.Write(item + " ");
            }
        }
    }
}















