using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Assignment
{

    class Assignment
    {
        static void Main(string[] args)
        {
            Assignment obj1 = new Assignment();
            Assignment obj2 = new Assignment();
            Assignment obj3 = new Assignment();


            int ID1;
            int ID2;
            int ID3;

            
                ID1 = 0;
                ID2 = 3;
                ID3 = 1;

                if (ID1 == ID2)
                {
                    Console.WriteLine("number 1 and to are equal.");
                }
                else if (ID1 > ID3)
                {
                    Console.WriteLine("number 1 are bigger than number 3.");
                }

            Console.ReadLine();

        }
    }
}
