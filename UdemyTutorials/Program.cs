// See https://aka.ms/new-console-template for more information
using System.Data.Common;

//Simple calculator using if else statements
Console.Write("number 1: ");
string userInput1 = Console.ReadLine();
int num1 = int.Parse(userInput1);


Console.Write("operator: ");
string operatorS = Console.ReadLine();

Console.Write("number 2: ");
string userInput2 = Console.ReadLine();
int num2 = int.Parse(userInput2);

int results = 0;

if(operatorS == "+" )
{
    results = num1+num2;
}
else if(operatorS == "-" )
{
    results = num1 - num2;  
}
else if(operatorS == "*" )
{
    results = num1 * num2;
}
else
{
    results = num1 / num2;
}
Console.WriteLine(num1 + " "+operatorS +" "+num2 +" = " + results);



//A function that converts points to grades using a switch statement
string ConvertPointsToGrade(int points)
{
    string gradeResults;
    switch (points)
    {
        case 9:
        case 8:
        case 7:
            gradeResults = "A";
            break;
        case 5:
        case 4:
            gradeResults = "B";
            break;
        default:
            gradeResults = "C";
            break;
    }
}
