using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_13._11
{
    class MyException : Exception
    {
        public override string Message { get { return "test " + base.Message; } }
    }
}
