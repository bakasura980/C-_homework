using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете име");
            Console.WriteLine("Въведете години");
            Console.WriteLine("Въведете години трудов стаж :");
            Console.WriteLine("Въведете предмет");
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int work_exp;
            do
            {
                work_exp = int.Parse(Console.ReadLine());
            } while (work_exp < 0);

            string predmet = Console.ReadLine();
            Teacher teacher = new Teacher(name, age, work_exp, predmet);
            teacher.PrintInfo(null);
            teacher.Hello();
            teacher.Homework();
            teacher.Bye();
            Console.WriteLine();
            //Console.WriteLine(Teacher.activeCount);
            //Console.WriteLine();
            Console.WriteLine("Въведете име");
            Console.WriteLine("Въведете години");
            Console.WriteLine("Въведете години трудов стаж :");
            Console.WriteLine("Въведете университет");
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            do
            {
                work_exp = int.Parse(Console.ReadLine());
            } while (work_exp < 0);
            string universe = Console.ReadLine();
            Lecture lecture = new Lecture(name, age, work_exp, universe);
            lecture.PrintInfo(null);
            lecture = new Lecture();
            lecture.Hello();
            lecture.Homework();
            lecture.Exercise1("2", "3");
            lecture.Exercise1("1", "2", "3");
            lecture.Exercise1("1");
            Console.WriteLine();
            //Console.WriteLine(Lecture.activeCount);
            //Console.WriteLine();
            Console.WriteLine("Въведете име");
            Console.WriteLine("Въведете години");
            Console.WriteLine("Въведете години трудов стаж :");
            Console.WriteLine("Въведете университет");
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            do
            {
                work_exp = int.Parse(Console.ReadLine());
            } while (work_exp < 0);
            universe = Console.ReadLine();
            Console.WriteLine("Ако не сте главен асистент въведете No");
            string value1 = Console.ReadLine();
            bool value = true;
            if (value1 == "No")
            {
                value = false;
            }
            Assistant assistant = new Assistant(value, name, age, work_exp, universe);
            assistant.HeadAssis();
            assistant.PrintInfo(null);
            assistant.Homework();
            assistant.CheckExam();
            assistant.Articles();
            Console.WriteLine();
            //Console.WriteLine(Assistant.activeCount);
            //Console.WriteLine();
            Console.WriteLine("Въведете име");
            Console.WriteLine("Въведете години");
            Console.WriteLine("Въведете години трудов стаж :");
            Console.WriteLine("Въведете университет");
            Console.WriteLine("Въведете титла");
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            do
            {
                work_exp = int.Parse(Console.ReadLine());
            } while (work_exp < 0);
            universe = Console.ReadLine();
            string title = Console.ReadLine();
            Professor professor = new Professor(title, name, age, work_exp, universe);
            professor.PrintInfo(null);
            professor.Title_agework();
            professor.Homework();
            professor.Exam();
            Console.WriteLine();
            //Console.WriteLine(Professor.activeCount);
            //Console.WriteLine();
            Console.WriteLine("Въведете име");
            Console.WriteLine("Въведете години");
            Console.WriteLine("Въведете години трудов стаж :");
            Console.WriteLine("Въведете предмет");
            Console.WriteLine("Въведете инфо за университета");
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            do
            {
                work_exp = int.Parse(Console.ReadLine());
            } while (work_exp < 0);
            universe = Console.ReadLine();
            string info = Console.ReadLine();
            CollegeTeacher collegeteacher = new CollegeTeacher(info, name, age, work_exp, predmet);
            collegeteacher.PrintInfo(null);
            collegeteacher.Homework();
            Console.WriteLine();
            //Console.WriteLine(CollegeTeacher.activeCount);
            //Console.WriteLine();
            Console.WriteLine("Въведете име");
            Console.WriteLine("Въведете години");
            Console.WriteLine("Въведете години трудов стаж :");
            Console.WriteLine("Въведете предмет");
            Console.WriteLine("Въведете класове,следа като въведете класовете си напишете Stop");
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            do
            {
                work_exp = int.Parse(Console.ReadLine());
            } while (work_exp < 0);
            predmet = Console.ReadLine();
            List<string> list = new List<string>();
            string value3; int i = 0;
            do
            {
                if (i == 5)
                {
                    value3 = "Stop";
                }
                else
                {
                    value3 = Console.ReadLine();
                    if (value3 != "Stop")
                    {
                        list.Add(value3);
                    }
                }
                i++;
            } while (value3 != "Stop");
            SchoolTeacher schoolteacher1 = new SchoolTeacher(name,age,work_exp,predmet);
            schoolteacher1.PrintInfo(null);
            SchoolTeacher schoolteacher = new SchoolTeacher(list);
            schoolteacher.Homework();
            schoolteacher.Amazing();
            schoolteacher.PrintList();
            Console.WriteLine();
            Console.WriteLine("Създадени са {0} обекта от наследниците на Person", Person.activeCount);
        }
    }
}
