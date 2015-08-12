using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace class_objects_3
{
    class Triangle_90
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        private double c;

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        
        public Triangle_90(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Hipo()
        {
            c = (a*a) + (b*b);
            c = Math.Sqrt(c);
            Console.WriteLine("Хипотенузата = {0}", c);
        }

        public void Ygli()
        {
            a = b / c;
            a = Math.Asin(a) * 180 / Math.PI;
            b = 90 - a;
            Console.WriteLine("Ъгли : {0}, {1}, {2}", 90, Math.Round(a, 2), Math.Round(b, 2));
        }

    }
}
