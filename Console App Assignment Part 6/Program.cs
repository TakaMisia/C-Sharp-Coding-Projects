using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop {
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("It is list of my family member: ");

            List<string> Names = new List<string>()
            { "Misia", "Piotr", "Vicki", "Misia", "Ewelina", "Gordon", "Sparki" };
            Names.ForEach(Console.WriteLine);
            Console.WriteLine("Choose my name from list: ");
            string nameChoice = Console.ReadLine();
            Console.WriteLine("You choose one name from " + Names.Count);
            foreach (string nameChoices in Names)
            {
                if (nameChoice == "Misia")
                {
                    Console.WriteLine("You guess my name.");
                    return;
                }
                else if (nameChoice == "Piotr")
                {
                    Console.WriteLine("it s my fiance. ");
                    return;

                }
                else if (nameChoice == "Vicki")
                {
                    Console.WriteLine("its my daughter. ");
                    return;

                }
                else if (nameChoice == "Ewelina")
                {
                    Console.WriteLine("its my mother. ");
                    return;

                }
                else if (nameChoice == "Gordon")
                {
                    Console.WriteLine("its my stepfather.");
                    return;

                }
                else if (nameChoice == "Sparki")
                {
                    Console.WriteLine("Its dog my mother.  ");
                    return;

                }

            }

        }
    }
}


//Console.WriteLine("Please , Choose my name from that list: ");
//for (int f = 0; f < Names.Count; f++)
//{
//    if (Names[f] == "Ewelina")
//    {
//        Console.WriteLine("She is my mother. Try again");
//    }
//    Console.ReadLine();
//}