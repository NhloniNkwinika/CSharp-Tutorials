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
            Console.WriteLine("----check whether a given number is even");

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

            /*program to check whether a given number is prime or not. using a while loop*/
            Console.WriteLine("");
            Console.WriteLine("----check whether a given number is prime");

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool prime = true;
            while(prime && (number/1 == number))
            {
                if(number % 2 == 0) 
                {
                    prime = false;
                    Console.WriteLine(number + " is not a prime ", prime);
                }
                else
                {
                    Console.WriteLine(number +" is a prime ", prime);
                }
            }


            Console.WriteLine("");
            Console.WriteLine("----check whether a given number is divisible by 7 ");
            /*calculate the sum of all odd integers in the range [1…n], which are not 
            divisible by 7 by using the for-loop:*/

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                if (i % 7 == 0)
                {
                    continue; //stops the current iteration of the inner loop,without terminating the loop.
                }
                sum += i;
            }
            Console.WriteLine("sum = " + sum);

            Console.WriteLine("");
            Console.WriteLine("----Display the elements in an array using a for each loop ");

            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };
            foreach (int i in numbers)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            string[] towns = { "London", "Paris", "Milan", "New York" };
            foreach (string town in towns)
            {
                Console.Write(" " + town);
            }
        }
    }
}