using System;

public class Fiendeklass
{
    string name;
    int hp;
    int dmg;

    static string[] names = ["goblin", "orc", "troll", "nazgull", "oliphant", "Smaug"];
    static int[] maxHealth = [20, 40];
    static int[] maxDamage = [5, 20];



    int monsterHealth = Random.Shared.Next();

    public Fiendeklass()
    {
        int n = Random.Shared.Next(names.Length);
        name = names[n];
        hp = Random.Shared.Next(maxHealth[n] / 2, maxHealth[n]);
        dmg = Random.Shared.Next(maxDamage[])
    }
}
