using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Assistant : Lecture
    {
        private bool head;

        public bool Head
        {
            get { return head; }
            set { head = value; }
        }

        
        public Assistant(bool head, string name, int age, int awork, string university)
            : base(name, age, awork, university)
        {
            this.head = head;
            activeCount+=0;
            
        }

        
        public override void PrintInfo(object pray)
        {
            Console.WriteLine("На {0} години съм", Age);
            Console.WriteLine("Моят трудов стаж е {0} и работя в {1}", Awork, University);
        }

        public void HeadAssis()
        {
            Console.WriteLine("Моето име е {0} и съм {1} асистент", Name, this.head);
        }
        //protected override string GetInfo()
        //{
        //    return "My age is " + this.Age + ", my work expirience is " + this.Awork + " and i work in " + this.University;
        //}

        protected override string GetHomework()
        {
            return ("Проверявам различни домашни");
        }

        public void CheckExam()
        {
            Console.WriteLine("Проверявам изпити");
        }
        public void Articles()
        {
            Console.WriteLine("Пиша научни статии");
        }
       
    }
}
