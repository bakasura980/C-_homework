using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework14
{
    public class AgeIsNotNumberException : Exception
    {
        public AgeIsNotNumberException(string message)
            :base(message)
        {
        }
    }
}