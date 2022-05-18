using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess how old I am ? tips : over 18 less ");
            int old = Convert.ToInt32(Console.ReadLine());
            bool agecorrect = old == 24;

            while (agecorrect == false)
            {
                switch (old)
                {
                    case 19:
                        Console.WriteLine("You wrote 19, I am older. Try  agian.");
                        Console.WriteLine("Guess how old I am ?  tips : over 18 less ");
                        old = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 20:
                        Console.WriteLine("You wrote 20, I am older. Try  agian.");
                        Console.WriteLine("Guess how old I am ?  tips : over 18 less ");
                        old = Convert.ToInt32(Console.ReadLine());
                        break;


                    case 21:
                        Console.WriteLine("You wrote 21, I am older. Try  agian.");
                        Console.WriteLine("Guess how old I am ?  tips : over 18 less ");
                        old = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 22:
                        Console.WriteLine("You wrote 22, I am older. Try  agian.");
                        Console.WriteLine("Guess how old I am ? tips : over 18 less ");
                        old = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 23:
                        Console.WriteLine("You wrote 23, I am older. Try  agian.");
                        Console.WriteLine("Guess how old I am ?tips : over 18 less ");
                        old = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 24:
                        Console.WriteLine("You wrote 24.THAT IS RIGHT ANSWER. Congratulations!!");
                        agecorrect = true;
                        break;

                    case 25:
                        Console.WriteLine("You wrote 25, I am younger. Try  agian.");
                        Console.WriteLine("Guess how old I am ? tips : over 18 less ");
                        old = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 26:
                        Console.WriteLine("You wrote 26, I am younger. Try  agian.");
                        Console.WriteLine("Guess how old I am ?tips : over 18 less ");
                        old = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 27:
                        Console.WriteLine("You wrote 27, I am younger. Try  agian.");
                        Console.WriteLine("Guess how old I am ? tips : over 18 less ");
                        old = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 28:
                        Console.WriteLine("You wrote 28, I am younger. Try  agian.");
                        Console.WriteLine("Guess how old I am ?  tips : over 18 less ");
                        old = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 29:
                        Console.WriteLine("You wrote 29, I am younger. Try  agian.");
                        Console.WriteLine("Guess how old I am ?  tips : over 18 less ");
                        old = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 30:
                        Console.WriteLine("You wrote 30, I am younger. Try  agian.");
                        Console.WriteLine("Guess how old I am ?  tips : over 18 less ");
                        old = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("wrong answer.");
                        Console.WriteLine("Guess how old I am ?  tips : over 18 less ");
                        old = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.ReadLine();


            Console.WriteLine("Do u have any children? ");
            int child = Convert.ToInt32(Console.ReadLine());
            bool childsum = child == 1;


            do
            {
                switch (child)
                {
                    case 0:
                        Console.WriteLine("You wrote 0,  Try  agian.");
                        Console.WriteLine("Do u have any children? ");
                        child = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 1:
                        Console.WriteLine("You wrote 1 .That correct.");
                        childsum = true;
                        break;


                    case 2:
                        Console.WriteLine("You wrote 2. Try  agian.");
                        Console.WriteLine("Do u have any children? ");
                        child = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Do u have any children? ");
                        child = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (childsum == false);
        }
    }
}
