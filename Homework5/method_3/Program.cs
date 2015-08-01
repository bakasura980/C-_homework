using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //От 1, 10 са числата,за да може всеки да си ги провери на ум и да види, че работи :3 
            Random rand = new Random();
            int sum = 1, value1 = 0;
            for (int j = 1; j < 11; j++)
            {
                for (int i = 1; i < 4; i++)
                {
                    value1 = rand.Next(1, 10);
                    RandomNumbers(ref value1, ref sum);
                    Console.WriteLine(value1);
                }
                Console.WriteLine(sum);
                sum = 1;
            }
            
        }

        private static int RandomNumbers(ref int value1 , ref int sum)
        {
            sum *= value1;
            return sum;
        }
    }
}
