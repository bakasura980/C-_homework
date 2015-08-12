using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_objects_2
{
    class SUV : Car
    {
        private bool offroad;

        public bool Offroad
        {
            get { return offroad; }
            set { offroad = value; }
        }

        public SUV(int car_cost, bool offroad)
            :base(car_cost)
        {
            this.offroad = offroad;
            Console.WriteLine("Цена: {0} , високопроходимост: {1}", car_cost, offroad);
        }
    }
}
