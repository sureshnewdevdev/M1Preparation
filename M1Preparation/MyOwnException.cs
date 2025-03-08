using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1Preparation
{
    public class MyOwnException : Exception
    {
        public override string Message => $"{DateTime.Now.ToString()} - Internal Exception at execuation";
    }
}
