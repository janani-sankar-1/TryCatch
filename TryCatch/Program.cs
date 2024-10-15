using System;
using System.Collections.Generic;
namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                Console.Write("enter first number:");
                string input1 = Console.ReadLine();
                a = int.Parse(input1);
                Console.Write("enter second number:");
                string input2 = Console.ReadLine();
                b = int.Parse(input2);

                int c = a / b;
                Console.WriteLine("Result of division" + c);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
