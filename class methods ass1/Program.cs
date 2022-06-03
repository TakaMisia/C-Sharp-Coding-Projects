using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_methods_ass1
{
    class Program
    {
        static void Main(string[] args)
        {
            maths obj1 = new maths();

            Console.WriteLine("Please write number from  0 to 200");
            int intsum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number time 2  is  " + obj1.multi(intsum));

            Console.WriteLine("Please write decimal number to convert to an integer.");
            decimal decsum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Your decimal as an interger is " + obj1.deccon(decsum));

            Console.WriteLine("Please write string number to convert to an integer.");
            string stringsum = Console.ReadLine();
            Console.WriteLine("Your string as an interger is " + obj1.stringcon(stringsum));

            Console.ReadLine();
        }
    }
}