using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class CollegeTeacher : Teacher
    {

      

        private string infocollege;

        public string Infocollege
        {
            get { return infocollege; }
            set { infocollege = value; }
        }

        
        
        public CollegeTeacher(string infocollege, string name, int age, int awork , string predmet)
            :base( name,  age,  awork, predmet)
        {
            this.infocollege = infocollege;
            activeCount+=0;
        }

       


        public override void PrintInfo(object pray)
        {
            Console.WriteLine("Аз съм {0}, името ми е {1}", GetType().Name, Name);
            Console.WriteLine("Годините са ми {0} и информацията за колежа ми е : {1}", Age, this.infocollege);
        }


        protected override string GetHomework()
        {
            return ("Проверявам домашни");
        }

    }
}
