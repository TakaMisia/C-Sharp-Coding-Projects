using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a number ?");
            int number = Convert.ToInt32(Console.ReadLine());

            answer xyz = new answer();

            Console.WriteLine("Your number dividedby 2  is " + xyz.divide(number));
            Console.WriteLine("Your number minus 4  is " + xyz.minus(number));
            Console.WriteLine("Your number times 7  is " + xyz.multi(number));
            Console.ReadLine();
        }
    }
}
