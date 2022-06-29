using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Assignment
{
        class Employee 
        {
            public int ID1 { get; set; }
        public int ID2 { get; set; }

        public static bool operator == (Employee employee, Employee employee2)
            {
            //summary

            if (employee.ID1 == employee.ID2)
                return true;
            else  
                return false;
            }
            public static bool operator != (Employee employee, Employee employee2)
            {
                if (employee.ID1 == employee2.ID2)
                    return true ;
                else
                    return false;
            }
          


        }
    
}
