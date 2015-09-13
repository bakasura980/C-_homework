using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_1
{
    class Program
    {
        static Thread thread1, thread2, thread3, thread4, thread5;
        static void Main(string[] args)
        {
            thread1 = new Thread(() => PrintStartNameComplete("thread1"));
            thread2 = new Thread(() => PrintStartNameComplete("thread2"));
            thread3 = new Thread(() => PrintStartNameComplete("thread3"));
            thread4 = new Thread(() => PrintStartNameComplete("thread4"));
            thread5 = new Thread(() => PrintStartNameComplete("thread5"));
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
        }

        public static void PrintStartNameComplete(string name)
        {
            Random rand = new Random();
            Console.WriteLine("The {0} is started!", name);
            Thread.CurrentThread.Name = name;
            Console.WriteLine("I am {0}, nice to meet you :)", Thread.CurrentThread.Name);
            Thread.Sleep(rand.Next(1000, 10000));
            Console.WriteLine("Тhe {0} complete!", name);
        }
    }
}
