using System;


namespace task_8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write your First string");
            string value1 = Console.ReadLine();
            Console.WriteLine("Write your Second string");
            string value2 = Console.ReadLine();
            int i = 0, count,count1,i1 = 0,sum = 0, count2;
            count = value1.Length;
            count1 = value2.Length;
           
            for (i = 0; i < count; i++)
            {
                
              //  Console.WriteLine(value2[i1]);
                if (value1[i] == value2[i1])
                {
                    sum++;
                    i1++;
                    if (i1 == count1)
                    {
                        break;
                    }
                    count2 = i + 1;
                    if (value1[count2] != value2[i1])
                    {
                        break;
                    }
                }
                
                

            }
            if (sum == count1)
            {
                Console.WriteLine("Your second string exists in first(Yes)");
            }
            else Console.WriteLine("Your second string doesn't exist if first(No)");
        }
    }
}
