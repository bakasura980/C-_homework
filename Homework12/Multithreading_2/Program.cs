using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press [ENTER] to END of program");
            Console.WriteLine();
            ThreadPool.SetMaxThreads(7, 5);
            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(new
                    WaitCallback(PrintStartNameComplete));
            }
            Console.ReadLine();
        }

        public static void PrintStartNameComplete(object aParam)
        {
            Random rand = new Random();
            Console.WriteLine("The thread{0} is started!", Thread.CurrentThread.ManagedThreadId);
            Thread.CurrentThread.Name = Convert.ToString(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("I am thread{0}, nice to meet you :)", Thread.CurrentThread.Name);
            Thread.Sleep(500);
            Console.WriteLine("Тhe thread{0} complete!", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
