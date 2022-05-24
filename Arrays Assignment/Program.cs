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
            Console.WriteLine("Today is : ");
            string[] weekDays = new string[] { "Sunday", "Monday", "Tuesday", "Wendsday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine(weekDays[1]);

            int[] age = new int[] { 21, 22, 33, 24, 15, 16, };
            Console.WriteLine("I am " + age[3] + " years old.");
            Console.ReadLine();

            List<string> intlist = new List<string>();
            intlist.Add(weekDays[1]);
            intlist.Add(weekDays[2]);
            intlist.Add(weekDays[3]);
            intlist.Add(weekDays[4]);
            intlist.Add(weekDays[5]);
            intlist.Add(weekDays[6]);
            intlist.Add(weekDays[0]);

            Console.WriteLine("One week have a :" + intlist.Count + " days.");

            Console.ReadLine();

        }
    }
}
