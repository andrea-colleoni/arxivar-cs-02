using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_logging
{
    public class TestoNulloException : Exception
    {

        public TestoNulloException(string messaggio)
            : base(messaggio)
        {      
        }
    }
}
