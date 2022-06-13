using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_assignemnt
{
    public class Program
    {
        static void Main(string[] args)
        {

            Interfaces_Assignment.Employee employee = new Interfaces_Assignment.Employee();
            Interfaces_Assignment.IQuittable quit = new Interfaces_Assignment.Employee();
            Interfaces_Assignment.IQuittable obj1 = new Interfaces_Assignment.Employee();
            quit.Quit(employee);



            employee.FirstName = new List<string>() { "Misia", "Piotr", "Ewka" };
            employee.LastName = new List<string>() { "Brodnicka", "Kasiński", "Smith" };
            employee.ID = new List<int>() { 1, 2, 3 };

            foreach (string  LastName  in employee.LastName)
                {
                    employee.SayName(LastName);
                }
            Console.ReadLine();
        }
    }
}
   
