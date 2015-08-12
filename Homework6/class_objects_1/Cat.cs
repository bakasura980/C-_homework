using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_objects_1
{
    class Cat
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string age;

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public Cat(string name, string age)
        {
            this.name = name;
            this.age = age;
        }

        public void Say()
        {
            Console.WriteLine("The name of cat is {0} and it is {1} age", name, age);
        }
    }
}
