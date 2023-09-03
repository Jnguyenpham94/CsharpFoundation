
//GOod old FizzBuzz
using System;
/*
for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}
*/

for (int i = 1; i < 101; i++)
{
    string x = "";
    if (i % 3 == 0)
        x += "Fizz";
    if (i % 5 == 0)
        x += "Buzz";
    if (x == "")
        Console.WriteLine($"{i}");
    else
        Console.WriteLine($"{i} - {x}");
}
