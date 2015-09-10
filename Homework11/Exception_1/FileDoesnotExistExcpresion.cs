using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception_1
{
    class FileDoesnotExistExcpresion : Exception
    {
        public FileDoesnotExistExcpresion(string Massage)
            :base(Massage)
        {
        }
    }
}
