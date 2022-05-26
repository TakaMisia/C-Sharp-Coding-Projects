using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Type a number :");
            int typenum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type another  number :");
            int typenum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividiing that to number :");
            int typenum3 = typenum1 / typenum2;
            Console.WriteLine(typenum1 + " / " + typenum2 + " = " + typenum3);
            Console.ReadLine();

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please write diffrent number because we are unable divding by zero");
            return;
        }
        catch (FormatException ex )
        {
            Console.WriteLine("Write diffrent type");
            return ;
        }
 
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
    }
}