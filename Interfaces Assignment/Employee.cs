using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{
    internal class Employee : Person, IQuittable
    {
            public List <int> ID { get; set; }
            public void Quit (Employee employee)
            {
                Console.WriteLine("FAMILY MEMBERS");
            }
    }
}
