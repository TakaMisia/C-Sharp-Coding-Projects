using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program.");
            Console.WriteLine("Person 1");

            // person1
            Console.WriteLine("Hourly rate?");
            int rate1 = 15;
            Console.WriteLine (rate1);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week??");
            int perweek1 = 40;
            Console.WriteLine (perweek1);       
            Console.ReadLine();

            Console.WriteLine("Person 2");

            // person2
            Console.WriteLine("Hourly rate?");
            int rate2 = 20;
            Console.WriteLine(rate2);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week??");
            int perweek2 = 40;
            Console.WriteLine(perweek2);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 1:");
            int annual1 = 31200;
            Console.WriteLine(annual1);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 1:");
            int annual2 = 41600;
            Console.WriteLine(annual2);
            Console.ReadLine();

            Console.WriteLine("Person 1 makes more money than Person 2.");
            bool trueOrFalse = annual1 > annual2;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();


        }
    }
}

