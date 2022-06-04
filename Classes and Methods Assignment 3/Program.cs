using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods3
{
    class Program
    {
       public static void Main(string[] args)
        {

Sum2 total = new Classes_and_Methods_Assignment_3.Sum2; 

            Console.WriteLine("Please write number 1 to 40");
            int num1 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("Please write another number 0 to 40");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Your numbers added together are  " + Sum2.Twopar(num1, num2));
            }
            catch (FormatException)
            {
                Console.WriteLine("One number  was equal 0 another one was  :" + num1);
            }
            finally
            {
                Console.ReadLine();
            }



        }
    }
}