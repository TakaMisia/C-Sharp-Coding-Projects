
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
            Console.WriteLine("Write a number which i will be able to change for a text file");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num);
            using (StreamWriter file = new StreamWriter(@"C:\Users\00kas\Desktop\PITMAN\c# .net modules\Basic_C#_Programs\IO assignment\\numfile.txt", true))
            {
                file.WriteLine(num);
            }
        }
    }
}