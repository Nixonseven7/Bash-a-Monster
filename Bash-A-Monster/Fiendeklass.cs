using System;

public class Fiendeklass
{
    public string name;
    public int hp;
    public int dmg;
    public int spd;
    public int ac;
    public int hc;
    public int md;
    public int lootchance;
    public string loot;

    static string[] names = ["Goblin", "Orc", "Troll", "Nazgull", "Great spider", "Smaug - The Chiefest and Greatest of Calamities"];
    static int[] maxHealth = [15, 30, 60, 100, 200, 1000];
    static int[] maxDamage = [8, 20, 40, 35, 40, 100];
    static int[] maxSpeed = [15, 10, 6, 30, 20, 50];
    static int[] maxArmorClass = [13, 14, 15, 17, 18, 22];
    static int[] maxHitChance = [20, 20, 20, 20, 20, 30];
    static int[] Modifiers = [0, 1, 1, 3, 4, 10,]; 
    public string[] lootDrops = ["Bone necklace", "Rusty iron plate", "Steel shoulder pads", "Silver bracelet", "Silken cloak", "Golden Ring" ];
    static int [] maxLootChance = [50, 40, 30, 20, 10, 100];


    public Fiendeklass()
    {
        int n = Random.Shared.Next(names.Length);
        name = names[n];
        hp = Random.Shared.Next(maxHealth[n] / 2, maxHealth[n] + 1);
        dmg = Random.Shared.Next(maxDamage[n] / 2, maxDamage[n] + 1);
        spd = Random.Shared.Next(maxSpeed[n] / 2, maxSpeed[n] + 1);
        ac = Random.Shared.Next(maxArmorClass[n] * 3 / 4, maxArmorClass[n] + 1);
        hc = maxHitChance[n] + 1;
        loot = lootDrops[n];
        lootchance = Random.Shared.Next(maxLootChance[n] * 3 / 4, maxLootChance[n] + 1);
    }
}
