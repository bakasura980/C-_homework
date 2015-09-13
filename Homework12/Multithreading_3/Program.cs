using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_3
{
    class Program
    {
        static Thread thread1, thread2;
        static void Main(string[] args)
        {
            thread1 = new Thread(Thread1Task);
            thread2 = new Thread(Thread2Task);
            thread1.Start();
        }

        public static void Thread1Task()
        {
            for (int i = 0; i < 50001; i++)
            {
                Console.WriteLine(i);
                if (i == 25000 )
                {
                    thread2.Start();
                    thread2.Join();
                }
            }
        }

        public static void Thread2Task()
        {
            int i;
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("Running...");
                Thread.Sleep(500);
            }
        }
    }
}
