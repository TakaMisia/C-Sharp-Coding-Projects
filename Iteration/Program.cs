using System;
using System.Collections.Generic;

class Program
{
    static void Main (string[] args)
    {
        ////int interation 
        //int[] age = { 24, 45, 33, 70, 55, 34, 18, 90, 56, 39 };

        //for (int i = 0; i < age.Length; i++)
        //{
        //    if (age[i] > 66)
        //    {
        //        Console.WriteLine("I am on retire, because i have : " + age[i] + " years old.");
        //    }
        //    else if (age[i] < 66) 
        //    {
        //        Console.WriteLine("I still working becaue retire start from 66 i have: " + age[i] + " years old.");
        //    }
        //}
        //string interation
       
        //    string[] names = { "Misia", "Piotr", "Vicki", "Ewelina", "Gordon", "Sparki" };

        //for (int f = 0; f < names.Length; f++)
        //     {
        //        Console.WriteLine("This is my family member  wchich lived in UK: " + names[f]);
        //     }
        //    //{
        //    //if (names[f] == "Ewelina")
        //    //{
        //    //    Console.WriteLine("She is my mother. Her name is: " + names[f]);
        //    //}
        //    Console.ReadLine ();


        //List <int> age = new List <int> ();    
        //age.Add (24);
        //age.Add (45);
        //age.Add (33);
        //age.Add (70);
        //age.Add (55);
        //age.Add (34);
        //age.Add (18);
        //age.Add (90);
        //age.Add (56);
        //age.Add (39);

        //foreach (int i in age)
        //{
        //    Console.WriteLine (i);
        //}

        List<string> Names = new List<string> () { "Misia", "Piotr", "Vicki", "Ewelina", "Gordon", "Sparki"};

        foreach (string name in Names)
        {
            Console.WriteLine (name);
        }
        Console.ReadLine ();
    }
}