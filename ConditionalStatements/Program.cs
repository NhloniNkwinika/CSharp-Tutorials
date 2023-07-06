using System;
using System.Linq.Expressions;

namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Results of 2 assigned intergers");
            /* IF-ElSE Statement - The program code can be interpreted as follows: if x>3, the result at the end 
            is: "x is greater than 3", else the result is: "x is not greater 
            than 3".*/
            int x = 2;
            if (x > 3)
            {
                Console.WriteLine("X is greater than 3");
            }
            else
            {
                Console.WriteLine("X is not greater than 3");
            }

            Console.WriteLine("");
            Console.WriteLine("----Compare two numbers-------------------------------");

            //*This example allows a user to enter two numbers and make a comparison using IF statement*/

            Console.WriteLine("Enter the 1st number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number:");
            int y = Convert.ToInt32(Console.ReadLine());
            if (i > y)
            {
                Console.WriteLine("The first number is bigger than the second number ");
            }
            else if (i < y)
            {
                Console.WriteLine("The first number is less than the second number");
            }
            else
            {
                Console.WriteLine("Both numbers are equal");
            }

            Console.WriteLine("");
            Console.WriteLine("----find the biggest of three numbers using nested if statement-------------------------------");

            //This example that finds the biggest of three integers, using nested if statements
            Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num3");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int bigNumber = 0;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    bigNumber = num1;
                }
                else
                {
                    bigNumber = num3;
                }
            }
            else 
            {
                if (num2 > num3)
                {
                    bigNumber = num2;
                }
                else
                { 
                    bigNumber = num3;
                }
            }
            Console.WriteLine("The largest number is: " + bigNumber);
        }

    }
}