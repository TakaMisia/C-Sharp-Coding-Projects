using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Assignment
{

    class Employee
    {
        static void Main(string[] args)
        {

            int ID1;
            int ID2;

            
                ID1 = 0;
                ID2 = 3;


            //summary
            if (ID1 == ID2)
                Console.WriteLine("error id is the same ");
            else if (ID1 != ID2)
                Console.WriteLine("both obejct have it diffrent ID");

            Console.ReadLine();

        }
    }
}
