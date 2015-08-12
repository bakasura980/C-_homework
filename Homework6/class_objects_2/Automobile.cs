using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_objects_2
{
    class Automobile : Car
    {
        private int ex_fuel;

        public int Ex_fuel
        {
            get { return ex_fuel; }
            set { ex_fuel = value; }
        }

        public Automobile(int car_cost , int ex_fuel)
            : base(car_cost)
        {
            this.ex_fuel = ex_fuel;
            Console.WriteLine("Цена: {0} , разход на гориво: {1}/100 km", car_cost, ex_fuel);
        }
        
    }
}
