using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_objects_4
{
    class ConvertCelzii
    {
        private double convertion;

        public double Convertion
        {
            get { return convertion; }
            set { convertion = value; }
        }

        public ConvertCelzii(double convertion)
        {
            this.convertion = convertion;
            this.convertion *= 1.8;
            this.convertion += 32;
        }
    }
}
