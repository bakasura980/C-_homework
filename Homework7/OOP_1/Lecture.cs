using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Lecture : Person
    {
        private string university;

        public string University
        {
            get { return university; }
            set { university = value; }
        }

        private int maxhour;

        public int Maxhour
        {
            get { return maxhour; }
            set { maxhour = value; }
        }
        public Lecture()
        {
            this.maxhour = 10;
            activeCount+=1;
            Console.WriteLine("Макс лекции : {0}", maxhour);
        }

        

        public Lecture(string name, int age, int awork, string university)
            :base(name, age, awork)
        {
            this.university = university;
            activeCount+=1;
        }

        public virtual void PrintInfo(object pray)
        {
            Console.WriteLine("Аз съм {0}, казвам се {1} и съм на {2} години", GetType().Name, Name, Age);
            Console.WriteLine("Моят трудов стаж е {0} и работя в {1}", Awork, this.university);
        }
        //protected override string GetInfo()
        //{
        //    return "I am a techaer, my name is " + Name + ",my age is " + Age + "my working experience is " + Awork + "and i work in " + this.university;
        //}
        protected override string GetHomework()
        {
            return ("Проверявам домашни");
        }

        protected override string GetHello()
        {
            return ("Добър ден");
        }

        private string[] exercise;

        public string[] Exercise
        {
            get { return exercise; }
            set { exercise = value; }
        }
        public void Exercise1(params string[] exercises)
        {
            this.exercise = exercises;
            Console.Write("Упржнение : ");
            foreach (string exercise in exercises)
            {
                Console.Write(exercise + " ");
            }
            Console.WriteLine();
        }
       
    }
}
