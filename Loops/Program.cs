using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*This program prompt the user to enter a number and determine
            if it's a prime number. all even numbers will be counted and displayed at the end using a for loop */
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
                    Console.WriteLine(num + " is an even number");
                }
                else
                {
                    Console.WriteLine(num + " Not an even number");
                }


            }
            Console.WriteLine("The total of all the counted even numbers is " + count);


        }
    }
}