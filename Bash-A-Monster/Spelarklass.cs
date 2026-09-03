using System;
using System.Security.Cryptography.X509Certificates;
public class Spelarklass
{
    public string Class;
    public int hp;
    public int dmg;
    public int spd;
    public int ac;
    public int hc;
    public int md;
    

    static string[] Classes = ["barbarian", "paladin", "warrior", "ranger", "wizard"];
    static int[] Health = [120, 200, 100, 80, 70];
    static int[] Damage = [35, 15, 20, 30, 50];
    static int[] Speed = [10, 8, 15, 30, 20];
    static int[] ArmorClass = [16, 18, 15, 13, 12];
    static int[] HitChance = [20, 20, 20, 20, 20];
    static int[] HitModifiers = [1, 2, 3, 3, 2,];

    public Spelarklass()
    {
        int n = Random.Shared.Next(Classes.Length);
        Class = Classes[n];
        hp = Health[n];
        dmg = Damage[n];
        spd = Speed[n];
        ac = ArmorClass[n];
        hc = HitChance[n] + 1;
        md = HitModifiers[n];
    }


}
