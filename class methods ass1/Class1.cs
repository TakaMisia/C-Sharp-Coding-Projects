using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_methods_ass1
{
    class maths
    {
        public int multi(int x)
        {
            return x * 2;
        }
        //Create method to convert given decimal to interger.
        public int deccon(decimal x)
        {
            return Convert.ToInt32(x);
        }
        //Create method to convert given string to interger.
        public int stringcon(string x)
        {
            return Convert.ToInt32(x);
        }
    }
}
