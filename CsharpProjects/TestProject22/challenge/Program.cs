Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
string? response = Console.ReadLine();

if (response != null)
{
    if (ShouldPlay(response))
    {
        PlayGame();
    }
}

bool ShouldPlay(string answer)
{
    return answer.ToLower() == "y" ? true : false;
}

string WinOrLose(int target, int roll)
{
    return roll > target ? "You Win!" : "You Lose!";
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.Next(1, 6);
        var roll = random.Next(1, 6);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");
        string? response2 = Console.ReadLine();
        if (response2 != null)
        {
            play = ShouldPlay(response2);
        }
    }
}