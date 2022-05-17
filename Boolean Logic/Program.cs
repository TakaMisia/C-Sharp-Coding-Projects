using System;

namespace BooleanLogic
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age");
            int age = Convert.ToInt32
            (Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI violation?" +
            " Please answer True or False");
            bool dui = Convert.ToBoolean
            (Console.ReadLine());

           
            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = Convert.ToInt32
            (Console.ReadLine());

            Console.WriteLine("Qualified?");

            if (age > 15 && dui == false && ticket <= 3)
            {
               Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false.");
            }
        }
    }
}
