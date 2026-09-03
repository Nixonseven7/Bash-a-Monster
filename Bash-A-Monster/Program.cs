

using System.Runtime.Intrinsics.Arm;

Spelarklass Spelare = new Spelarklass();

int smaugDefeats = 0;
int spelarelliv = 1;
int rollZeroDmg = Random.Shared.Next(1, 21);
string [] Directions = ["Behind of", "To the right of", "To the left of", "in the corner to the right of", "in the corner to the left of"];



int Sleep = 50;
string print(string print)
{

    for (int i = 0; i < print.Length; i++)
    {
        Console.Write(print[i]);
        Thread.Sleep(Sleep);

        if (Console.KeyAvailable)
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Sleep = 0;
            }
        }
    }
    Console.WriteLine("");
    Sleep = 50;
    return print;
}

Console.Title = "Middle Earth";

print("- Cold stones pressed against your cheek bones as you open your eyes from a deep slumber.");
print("- The air is thick and the scent of dust and forged iron fills your waking moment.");
print("- You stand up to massive pillars of stone around you.");
print("- On a wall you see a single sentence with some words destroyed - Th/ Du/g£on an¤ *#&/$ of Erebors Mo-=/[]!¤.");
print("- You Realize You are in Erebor but cannot recall who you are.");
print("- until it clicks i am:");
Console.WriteLine();

string spelarenamn = Console.ReadLine();

Console.WriteLine();
print($"Yes how could i ever forget my own name i am {spelarenamn} and i am a {Spelare.Class}");
print($"- As {spelarenamn} revals in remembering their name they hear a strange sound coming from a giant door up ahead.");

while (smaugDefeats == 0 && spelarelliv == 1)
{
    print($"- {spelarenamn} walks up to the door.");

    Fiendeklass Fiende = new Fiendeklass();
    int FiendeHp = Fiende.hp;
    int SpelareHp = Spelare.hp;

    int RD = Random.Shared.Next(Directions.Length);
    string randomDirection = Directions[RD];

    if (Fiende.name == "Goblin" || Fiende.name == "Orc" || Fiende.name == "Troll")
    {
        print($"- When {spelarenamn} opens the door they find a {Fiende.name} and before {spelarenamn} could close the door the {Fiende.name} sees {spelarenamn}.");
        print($"- Both {spelarenamn} and the {Fiende.name} prepare for battle.");
        Console.WriteLine();
        print($"- ({spelarenamn} stats: dmg: {Spelare.dmg}  hp: {Spelare.hp}  speed: {Spelare.spd}  Armorclass: {Spelare.ac}  Maxhitchance: {Spelare.hc - 1}).");
        print($"- ({Fiende.name} stats: dmg: {Fiende.dmg}  hp: {Fiende.hp}  speed: {Fiende.spd}  Armorclass: {Fiende.ac}  Maxhitchance: {Fiende.hc - 1}).");
        Console.WriteLine();

        if (Spelare.spd >= Fiende.spd)
        {
            print($"- {spelarenamn} is faster so they can attack first");
            while (FiendeHp > 0)
            {
                int spelarAttackRoll = Random.Shared.Next(Spelare.hc) + 1 + Spelare.md;
                int fiendeAttackRoll = Random.Shared.Next(Fiende.hc) + 1 + Fiende.md;

                print($"Press any key to attack");
                Console.ReadLine();

                if (spelarAttackRoll == 20)
                {
                    print($"- As {spelarenamn} gets ready to attack they muster up their mightiest attack and does {Spelare.dmg * 2} damage");
                    FiendeHp -= Spelare.dmg * 2;
                    if (FiendeHp <= 0)
                    {
                        print($"- The {Fiende.name} died");
                        print($"- after the {Fiende.name} falls you search their corpse and you find...");
                        print($"- ");
                        print($"- {randomDirection} the newly made mangled corpse you see another door");
                    }
                    else
                    {
                        print($"- Now the {Fiende.name} has {FiendeHp} health left.");
                        print($"- Now the {Fiende.name} attacks");
                        if (fiendeAttackRoll == 20)
                        {
                            print($"- {Fiende.name} hits you with their mightiest attack and does {Fiende.dmg * 2}");
                            SpelareHp -= Fiende.dmg * 2;
                            if (SpelareHp <= 0)
                            {
                                print($"- {spelarenamn} gets hit and takes their last breath but not before muttering in a weak voice 'this is not over!' after the words leaves their body their soul follows....");
                                spelarelliv --;
                                
                            }
                            else
                            {
                                print($"- Now the {spelarenamn} has {SpelareHp} health left.");
                            }
                        }
                        else if (fiendeAttackRoll == 1)
                        {

                        }

                        else if (fiendeAttackRoll >= Spelare.ac && fiendeAttackRoll != 20)
                        {

                        }
                    }
                }

                else if (spelarAttackRoll == 0)
                {
                    print($"- As {spelarenamn} gets ready to attack they muster up their mightiest attack AND.....");
                    print($"- They slip and fall on a pebble and hit their jaw on som rubble.... {spelarenamn} takes {rollZeroDmg} (impressive)");
                    SpelareHp -= rollZeroDmg;
                    if (FiendeHp <= 0)
                    {
                        print($"- The {Fiende.name} died");
                    }
                    else
                    {
                        print($"- Now the {Fiende.name} has {FiendeHp} health left.");
                    }
                }

                else if (spelarAttackRoll >= Fiende.ac && spelarAttackRoll != 20)
                {
                    print($"- {spelarenamn} attacks and does {Spelare.dmg} damage");
                    FiendeHp -= Spelare.dmg;
                    if (FiendeHp <= 0)
                    {
                        print($"- The {Fiende.name} died");
                    }
                    else
                    {
                        print($"- Now the {Fiende.name} has {FiendeHp} health left.");
                    }
                }

                else
                {
                    print($"- As {spelarenamn} goes to attack the {Fiende.name} dodges the attack like a true master");
                }
            }
        }
        else
        {
            print($"- {Fiende.name} is faster so they can attack first");
        }
    

    else if (Fiende.name == "Nazgull")
    {
        print($"- ");

        if (Spelare.spd >= Fiende.spd)
        {

        }
    }

    else if (Fiende.name == "Great spider")
    {
        print($"- ");

        if (Spelare.spd >= Fiende.spd)
        {

        }
    }

    else if (Fiende.name == "Smaug - The Chiefest and Greatest of Calamities")
    {
        print($"- ");

        if (Spelare.spd >= Fiende.spd)
        {

        }
    }

}

if (spelarelliv == 0)
{
    print("- Press any key to close the console");
}
else if (smaugDefeats == 1)
{
    print($"");
}

Console.ReadLine();








