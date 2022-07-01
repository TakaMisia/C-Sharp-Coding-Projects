
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number, please");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number);
            using (StreamWriter file = new StreamWriter(@"C:\Users\00kas\Desktop\PITMAN\c# .net modules\Basic_C#_Programs\DateTime\\number.txt", true))
            {
                file.Write(DateTime.Now);
                file.Write("  ");
                file.WriteLine(number);

            }
        }
    }
}