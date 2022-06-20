using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();

            List<string> Names = new List<string>()
            {
                "Misia", "Piotrek", "Ewka", "Vicki", "Gordon" 
            };

            List<string> Surnames = new List<string>()
            {
                "Brodnicka", "Kasiński", "Smith", "Kasińska", "Smith"
            };

            List<int> Ages = new List<int>()
            {
               24, 33, 48, 1, 62
            };

            List<int> Index = new List<int>()
            {
               0, 1, 2, 3, 4
            };

            Employee objects = new Employee();
            foreach (int index in Index)
            {
                objects.Name = Names[index];
                objects.Surname = Surnames[index];
                objects.Age = Ages[index];
                Employees.Add(objects);
            }

            Console.WriteLine("its my  whole family : ");

            foreach (Employee employee in Employees.FindAll(a => a.Age >= 1))
            {
                Console.WriteLine(employee.Name + " " + employee.Surname + " " + employee.Age);

            }

            Console.WriteLine("It is my parents : ");

            foreach (Employee Employee in Employees)
            {
                Console.WriteLine(Names[2] + " " + Surnames[2] + " " + Ages[2]);

                Console.WriteLine(Names[4] + " " + Surnames[4] + " " + Ages[4]);
                break;
            }

            Console.WriteLine("My daugter is : ");

            foreach (Employee employee in Employees.FindAll(i => i.Name == "Vicki"))
            {
                Console.WriteLine(employee.Name + " " + employee.Surname + " " + employee.Age);
            }


            Console.ReadLine();
        }
    }
}