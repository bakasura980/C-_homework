using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Работи само, ако матрицата е 4х4 , надявам се ,че ще имам време да пробвам със "Switch"
            //Доста код и е харднат ,ама сега не ми хрумва по-добра идея :Д(Има време):Д :Д :Д
            Console.WriteLine("Въведете големина на матрицата");
            int value1 = int.Parse(Console.ReadLine());
            int[,] arr = new int[value1 + 1,value1 + 1];
            int i, count, count1, j = 1;
            for(i = 1; i < value1 + 1; i++)
            {
                arr[j, i] = i;
            }
            
            count = i;
            
            if (i == value1 + 1)
            {
                i--;
                
                for (j = 2; j < value1 + 1 ; j++)
                {
                    arr[j, i] = count;
                    count++;
                }
            }
           
            count1 = count;
            
            if (j == value1 + 1)
            {
                j--;
                
                for ( i = value1 - 1; i > 0; i--)
                {
                    arr[j, i] = count1;
                    count1++;
                }
            }
            count = count1 - 1;
            
            if (i == 0)
            {
                i++;
                for ( j = value1; j > 1; j--)
                {
                    arr[j, i] = count;
                    count++;
                }
            }
            count1 = count;
            if (j == 1)
            {
                j++;
                for (i = 2; i < value1 ; i++)
                {
                    arr[j, i] = count1;
                    count1++;
                }
            }
            count = count1;
            if (i == value1)
            {
                j++;
                i--;
                    for (i = value1 -1; i > 1; i--)
                    {
                        arr[j, i] = count;
                        count++;
                    }
            }
            Console.WriteLine();
            for (j = 1; j < value1 + 1; j++)
            {
                for (i = 1; i < value1 + 1; i++)
                {
                    Console.Write(arr[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
