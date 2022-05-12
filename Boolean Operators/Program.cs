using System;

namespace BooleanOperators
{
    class program
    {
        static void Main(string[] args)
        {
            //// statment and if is both property always will bee false 
            //Console.WriteLine(true && false);
            //Console.WriteLine(false && true);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            ////statment or true is more important 
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || true);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);

            ////statment equal  if both as the same then is true if  one is diffrent is false
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == true);
            //Console.WriteLine(true == true);
            //Console.WriteLine(false == false);

            //// not equal 
            //Console.WriteLine(true != false); //right statment
            //Console.WriteLine(false != true);  //right statment
            //Console.WriteLine(true != true);
            //Console.WriteLine(false != false);

            //  XOR operator  similar to not equal valued true if 1 of this is true butnot both
            Console.WriteLine(true  ^false); 
            Console.WriteLine(false ^ true); 
            Console.WriteLine(true ^ true);
            Console.WriteLine(false ^ false);
        }
    }
}