using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_2
{
    class SentenceNotCompletedException : Exception
    {
        public SentenceNotCompletedException(string Massage)
           : base(Massage)
        {
        }
    }
}
