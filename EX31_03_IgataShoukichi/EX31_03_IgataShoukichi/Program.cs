using System;

namespace Ex31
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character("しむら人", 500, 2);
            Character character2 = new Character("ささっき", 1000, 25);
            Tank tank1 = new Tank("Tiger", 500000, 250);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125);
            tank2.bullet = 5;
            Cow cow1 = new Cow("牛", 1200, 90);
            Cat cat1 = new Cat("猫", 10000, 1500);
            Character[] characters = { character1, character2, tank1, tank2, cow1, cat1 };
            for (var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(character1);
            }
        }
    }
}