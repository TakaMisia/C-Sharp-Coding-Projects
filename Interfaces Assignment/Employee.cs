using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{
    internal class Employee : Person, IQuittable
    {
        string color = "pink";

            public List <int> ID { get; set; }
            public void Quit (Employee employee)
            {
            Employee favcolor = new Employee();

                Console.WriteLine("FAMILY MEMBERS our favorite color is "+  favcolor.color);
            }
    }
}
