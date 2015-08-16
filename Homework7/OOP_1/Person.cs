using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    abstract class Person
    {

        public static int activeCount = 0;

        private string name;

        protected string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        protected int Age
        {
            get { return age; }
            set { age = value; }
        }

        private int awork;

        protected int Awork
        {
            get { return awork; }
            set { awork = value; }
        }

        
        public Person()
        {
        }
        public Person(string name, int age, int awork)
        {
            this.name = name;
            this.age = age;
            this.awork = awork;
        }

        internal void Hello()
        {
            Console.WriteLine(GetHello());
        }

        protected abstract String GetHello();

        internal void Homework()
        {
            Console.WriteLine(GetHomework());
        }


        protected abstract String GetHomework();

        

        //internal void PrintInfo()
        //{
        //    Console.WriteLine(GetInfo());
        //}

        //protected abstract String GetInfo();
    }
}
