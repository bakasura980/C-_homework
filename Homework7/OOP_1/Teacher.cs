using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Teacher : Person

    {

        

        private string predmet;

        public string Predmet
        {
            get { return predmet; }
            set { predmet = value; }
        }

        public Teacher()
        {
            activeCount++;
        }

        
        public Teacher(string name, int age, int awork , string predmet)
             :base (name, age, awork)
        {
            this.predmet = predmet;
            activeCount++;
        }

        

        //protected override string GetInfo()
        //{
        //    return "I am a techaer, my name is " + Name + ",my age is " + Age + "my working experience is " + Awork + "and i teach " + this.predmet;
        //}
        protected override string GetHomework()
        {
            return ("Проверявам домашни");
        }

        protected override string GetHello()
        {
            return ("Добър ден");
        }

        public void Bye()
        {
            Console.WriteLine("Довиждане");
        }

        public virtual void PrintInfo(object pray)
        {
            Console.WriteLine("Аз съм {0}, казвам се {1} и съм на {2} години", GetType().Name, Name, Age);
            Console.WriteLine("Моят трудов стаж е {0} и преподавам {1}", Awork, this.predmet);
        }
    }
}
