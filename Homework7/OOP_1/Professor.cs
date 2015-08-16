using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Professor : Lecture
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        
        public Professor(string title, string name, int age, int awork, string university)
            : base(name, age, awork, university)
        {
            this.title = title;
            activeCount+=0;
        }
        
        public override void PrintInfo(object pray)
        {
            Console.WriteLine("Аз съм {0}, името ми е {1}",GetType().Name, Name);
            Console.WriteLine("На {0} години съм и работя в {1}", Age, University);
        }
        public void Title_agework()
        {
            Console.WriteLine("Титлата ми е {0} професор и имам {1} години трудов стаж", title, Awork);
        }

        protected override string GetHomework()
        {
            return ("Проверявам различни домашни");
        }

        public void Exam()
        {
            Console.WriteLine("Провеждам изпити");
        }
    }
}
