using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 strings
            string author = "Michalina Brodnicka";
            string description = "I am young motivated person." +
                "\n I am a mother also. \n \t" +
                " my daughter name is Victoria.";

            author = author.ToUpper();
            Console.WriteLine(description);
            //uppper letter 
            Console.WriteLine(author);  
            Console.ReadLine();

           var sb = new System.Text.StringBuilder();   
            sb.AppendLine("Piotr Kasiński");


            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}