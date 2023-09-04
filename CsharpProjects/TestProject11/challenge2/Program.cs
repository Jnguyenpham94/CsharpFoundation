string? readResult;
string? end;

do
{
    Console.WriteLine("Enter a string:");
    readResult = Console.ReadLine();
    System.Console.WriteLine($"Read result is: {readResult} | end y/n?");
    end = Console.ReadLine();
    if (end == "y") break;
    else continue;
} while (readResult != null);

// capture user input in a string variable named readResult

int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
System.Console.WriteLine(validNumber);
System.Console.WriteLine(numericValue);