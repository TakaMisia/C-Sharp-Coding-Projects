using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    class Employee : Person
    {
        public int ID { get; set; }
        public void SayName(string FirstName, string LastName)
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        public void SayName()
        { }

    }
}
