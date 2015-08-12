using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_objects_2
{
    class Car
    {
        private int cost;

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public Car(int cost)
        {
            this.cost = cost;
        }
        

        
    }
}
