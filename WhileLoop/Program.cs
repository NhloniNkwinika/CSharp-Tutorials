//checks if the value of number is less than 10 using a while loop

//var number = 0;
//while (number < 10)
//{
//    number++;
//    Console.WriteLine($"The number is {number}");
//}
//Console.WriteLine("The loop is finished");

Console.Write("Enter a string: ");
var inputString = Console.ReadLine();
while (inputString.Length < 15)
{
    inputString += 'a';
    Console.WriteLine(inputString);
}
Console.WriteLine("The loop is finished");