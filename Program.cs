using System;

// Exception Handling | C# | Tutorial 24

namespace CSharpExercises_24
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number:  ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                //double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter another number:  ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                //double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The answer is  " + (num1 / num2));
            }
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                //Console.WriteLine(e.Message);
                //Console.WriteLine("Need to enter numbers only!");
                Console.WriteLine("Numbers only! Dum! Dum!");
            }
            finally
            {
                // some code should be run no matter what happens
                // put it here

            }

            Console.ReadLine();

        }
    }
}
