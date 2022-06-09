using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{
    
         class Person
        {
            public List <string> FirstName { get; set; }
            public List <string> LastName { get; set; }

            public void SayName(string  a = null, string b = null, string c = null)
            {
                Console.WriteLine( "Surname in my  family : " + a + b + c);
            }
        }
    

}

