using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
    public class sampleclass
    {
        public sampleclass()
        {
            Console.WriteLine("2");
        }
        public  sampleclass(int x): this()
        {
            Console.Write("Misia");
        }
        public sampleclass(int x, string y): this(10)
        {
            Console.WriteLine("5");
        }

    }
}
