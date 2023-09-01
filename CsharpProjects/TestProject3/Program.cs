﻿Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll b4: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

Console.WriteLine($"Dice roll + bonus: {roll1} + {roll2} + {roll3} = {total}");

if (total >= 16)
{
    Console.WriteLine("You got 16+ won a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You got 10+ won a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You got 7 won a trip for two!");
}
else
{
    Console.WriteLine("You got the consolation prize!! Won a kitten!");
}

string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}