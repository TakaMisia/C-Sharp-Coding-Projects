using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = new string[] { "Sunday", "Monday", "Tuesday", "Wendsday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("Enter a number 0 to 6 , please ");
            Console.WriteLine("Today is : ");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer <=6)
            {
             Console.WriteLine("you choose 1 day from 7 your day is :  " + weekDays[answer]);
            }
            else 
            {
                Console.Write("You write wrong number  you are allowed to  choose between 0 to 6 ");
            };
            Console.ReadLine();


            List<string> intlist = new List<string>();
            Console.WriteLine("Again Enter a number 0 to 6 , to guees day ");
            Console.WriteLine("you guess: ");
            int answerlist = Convert.ToInt32(Console.ReadLine());

            if (answerlist <= 6)
            {
                Console.WriteLine("your day is  :  "
           + weekDays[answerlist]);
            }
            else
            {
                Console.Write("Mistake ");
            };

            intlist.Add(weekDays[1]);
            intlist.Add(weekDays[2]);
            intlist.Add(weekDays[3]);
            intlist.Add(weekDays[4]);
            intlist.Add(weekDays[5]);
            intlist.Add(weekDays[6]);
            intlist.Add(weekDays[0]);

            Console.WriteLine("One week have it :" + intlist.Count + " days");
            intlist.ForEach( Console.WriteLine);
            Console.ReadLine();

            int[] age = new int[] { 21, 22, 33, 24, 15, 16, };
            Console.WriteLine("Enter a number 0 to 5 , ");
            int answerage = Convert.ToInt32(Console.ReadLine());
           
            if (answerage<=5)
            {
                Console.WriteLine("You entered number in my range Congrats!  You choose number: " + age[answerage] );
            }
         
            else
            {
                Console.Write("Wrong. You should enter number between 0 to 6 ");
            };
            Console.ReadLine();
        }
    }
}
