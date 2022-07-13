using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Tell me your age?");
                int age = int.Parse(Console.ReadLine());

                if (age <= 0)
                {
                    throw new ArgumentException();
                }
                else 
                {
                    throw new Exception();
                }

                int now = int.Parse(DateTime.Now.ToString("You are to young to watch that."));
                int sam = (now - age);
                int sam2 = (sam - 1);

                Console.WriteLine("You were born in " + sam2 + " or " + sam);
                Console.ReadLine();
                
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error! You write 0 or a negative number below it. ");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Technical probem please conntact with  us..");
                Console.ReadLine();
            }
        }
    }
}