using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    public class Operator
    {
        public int operate(int data, int input = 0)
        {
            return data + input;
        }
    }
}
