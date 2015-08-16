using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class SchoolTeacher : Teacher
    {

        private List<string> list = new List<string>();

        public List<string> List
        {
            get { return list; }
            set { list = value; }
        }
        public SchoolTeacher(string name, int age, int awork, string predmet)
            : base(name, age, awork, predmet)
        {
            activeCount+=0;
        }

        public virtual void PrintInfo(object pray)
        {
            Console.WriteLine("Аз съм {0}, казвам се {1} и съм на {2} години", GetType().Name, Name, Age);
            Console.WriteLine("Моят трудов стаж е {0} и преподавам {1}", Awork, Predmet);
        }
        public SchoolTeacher(List<string> list)
        {
            this.list = list;
            activeCount+= 0;
        }
        

        public void PrintList()
        {

            Console.WriteLine("Класовете са : ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " "); 
            }
            
        }
        protected override string GetHomework()
        {
            return ("Проверявам домашни");
        }

        public void Amazing()
        {
            Console.WriteLine("Забавлявам деца :) ");
        }
    }
}
