using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Assignment
{

    public enum Week
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thrusday,
        Friday,
        Saturday
    }
    class program
    {
        public static void Main()
        {
            Console.WriteLine("Please choose any day of the week");
            string choosen = Console.ReadLine();
            string actual = DateTime.Now.DayOfWeek.ToString();
            try
            {
                if (choosen == actual)
                {
                    Console.WriteLine("Your day is : " + choosen);
                }
                {
                    if (choosen != actual)
                        throw new ArgumentNullException();
                }
            }
            catch (ArgumentNullException)

            {
                Console.WriteLine("Please type real day of the week");
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}



