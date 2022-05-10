using System;

namespace MathOperation
{
    class program
    {
        static void Main(string[] args)
        {
            //addition
            int total = 25 + 25;
            Console.WriteLine(total);
            Console.ReadLine();

            //substraction
            int diffrence = 25 - 18;
            Console.WriteLine(diffrence);
            Console.ReadLine();

            //multiplication
            int product = 25 * 50;
            Console.WriteLine(product);
            Console.ReadLine();

            //division
            double half = 25 / 12.5;
            Console.WriteLine(half);
            Console.ReadLine();


            bool trueOrFalse = 25 > 50;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            // reminder
            int reminder = 25 % 7;
            Console.WriteLine(reminder);
            Console.ReadLine();
        }
    }
}