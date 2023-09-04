/*
You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster will start with 10 health points.
All attacks will be a value between 1 and 10.
The hero will attack first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
*/

int heroHealth = 10;
int monsterHealth = 10;
Random damage = new Random();

do
{
    int damaged = damage.Next(1, 11);
    monsterHealth -= damaged;
    Console.WriteLine($"Monster was damaged and lost {damaged} and now has {(monsterHealth)} health.");

    if (monsterHealth <= 0) continue;

    damaged = damage.Next(1, 11);
    heroHealth -= damaged;
    Console.WriteLine($"Hero was damaged and lost {damaged} and now has {(heroHealth)} health.");

} while (heroHealth > 0 && monsterHealth > 0);

System.Console.WriteLine(monsterHealth <= 0 ? "Hero wins!" : "Monster wins!");