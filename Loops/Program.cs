using System;
using System.Diagnostics.CodeAnalysis;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*This program prompt the user to enter a number and determine
            if it's a prime number. all prime numbers will be counted and displayed at the end */
            Console.WriteLine("");
            Console.WriteLine("----check whether a given number is prime");
            
            int count = 0;
            for (int i = 0; i < 4; i++) 
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) 
                {
                    count++;
                    Console.WriteLine(num + " is a prime");
                }
                else
                {
                    Console.WriteLine(num + " Not a prime number");
                }


            }
            Console.WriteLine("The total of all the counted prime numbers is "+ count);
        }
    }
}