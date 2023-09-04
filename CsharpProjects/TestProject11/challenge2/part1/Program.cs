
using System;

string? input;
int numValue = 0;
bool validNumber = false;
System.Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    input = Console.ReadLine();
    if (input != null)
    {

    }

    validNumber = int.TryParse(input, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }

} while (validNumber == false);

Console.WriteLine($"Your input value {numValue} has been accepted.");