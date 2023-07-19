//checks if the value of number is less than 10 using a while loop

using System.Diagnostics.Tracing;

//var number = 0;
//while (number < 10)
//{
//    number++;
//    Console.WriteLine($"The number is {number}");
//}
//Console.WriteLine("The loop is finished");

////determines the length of a string and add a character
//Console.Write("Enter a string: ");
//var inputString = Console.ReadLine();
//while (inputString.Length < 15)
//{
//    inputString += 'a';
//    Console.WriteLine(inputString);
//}
//Console.WriteLine("The loop is finished");

////Question 1:
///*Using the while loop, implement the CalculateSumOfNumbersBetween method,
// * which given two integers called firstNumber and lastNumber,
// * should calculate the sum of numbers between them (including the numbers themselves).*/
//int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
//{
//    int currentNumber = firstNumber;
//    int sum = 0;
//    while (currentNumber <= lastNumber)
//    {
//        sum += currentNumber;
//        currentNumber++;
//    }
//    return sum;
//}

//difference between a while and do while loop


string word;
do
{
    Console.Write("Enter a word: ");
    word = Console.ReadLine();
} 
while (word.Length < 10);
Console.WriteLine("The loop is finished");