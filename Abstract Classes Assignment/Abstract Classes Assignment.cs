using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();


            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName(employee.FirstName, employee.LastName);
            Console.ReadLine();
        }
    }
}