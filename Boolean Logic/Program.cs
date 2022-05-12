using System;

namespace BooleanLogic
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age");
            bool trueorfalse = 32 > 15;
            Console.WriteLine(trueorfalse);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI violation?");
            bool dui = 0 == 0;
            Console.WriteLine(dui);
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            bool ticket = 3 < 1;
            Console.WriteLine(ticket);
            Console.ReadLine();

            Console.WriteLine("Qualified?");
            bool qual = true && true ;
            Console.WriteLine(qual);
            Console.ReadLine();
        }
    }
}
