using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee<string> Names = new Employee<string>();


            Names.Things = new List<string>()
            {
                "Misia",
                "Piotr",
                "Ewelina"
            };


            Employee<int> Age = new Employee<int>();

            Age.Things = new List<int>()
            {
                24,
                32,
                48
            };
            Console.WriteLine("This is our names: ");
            Names.Things.ForEach(Console.WriteLine);
            Console.WriteLine("This is our age: ");
            Age.Things.ForEach(Console.WriteLine);

            Console.ReadLine();
        }
    }
}