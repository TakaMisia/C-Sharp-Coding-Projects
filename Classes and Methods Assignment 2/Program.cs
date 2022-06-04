using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_2
{

    class Program
    {
        static void Main(string[] args)
        {

            math xyz  = new math ();

            Console.WriteLine("Please write a number ");
            int intnum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your number is : " + intnum1);

            Console.WriteLine("Please write another number ");
            int intnum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your second  number is : " + intnum2);

            int total = intnum1 + intnum2;
            Console.WriteLine("Total result is " + total);
            Console.ReadLine();
        }
    }

}