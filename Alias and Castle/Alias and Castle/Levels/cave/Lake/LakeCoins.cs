using System;
using System.Collections.Generic;
using Alias_and_Castle.blanks_for_repetitive_actions;

namespace Alias_and_Castle.Levels.cave.Lake
{
    internal class LakeCoins
    {
        public static void Lake(string nameCharacter, List<MedKit> medKits, List<Weapon> weapons,
            List<LittleThings> littleThings, List<PlayerInventory> playerInventories, int damage, int heals, string weapon, string decision, Random random)
        {
            bool KeepCatchingObjects = true;

            while (KeepCatchingObjects)
            {
                Console.Clear();

                int randomItemNumberOfLake = random.Next(1, 100);
                int randomQuanity = random.Next(1, 5);

                if (randomItemNumberOfLake <= 70)
                {
                    Console.WriteLine($"{nameCharacter} выловил {littleThings[0].Name} ({randomQuanity})");
                    littleThings[0].Quantity += randomQuanity;
                }
                else if (randomItemNumberOfLake > 70 && randomItemNumberOfLake <= 80)
                {
                    Console.WriteLine($"{nameCharacter} выловил {medKits[0].Size} ({randomQuanity})");
                    medKits[0].Quantity += randomQuanity;
                }
                else if (randomItemNumberOfLake > 80 && randomItemNumberOfLake <= 90)
                {
                    Console.WriteLine($"{nameCharacter} выловил {medKits[1].Size} ({randomQuanity})");
                    medKits[1].Quantity += randomQuanity;
                }
                else if (randomItemNumberOfLake > 90 && randomItemNumberOfLake <= 98)
                {
                    Console.WriteLine($"{nameCharacter} выловил {medKits[2].Size} ({randomQuanity})");
                    medKits[2].Quantity += randomQuanity;
                }
                if (randomItemNumberOfLake > 98)
                {
                    Console.WriteLine($"{nameCharacter} выловил {weapons[3].Name}");
                    Console.WriteLine("Взять? 1)Взять \n2)Не брать");

                    string takeDecision = Console.ReadLine();
                    if (takeDecision == "1")
                    {
                        InventoryActions.AddToInventory(weapons[3], playerInventories);
                        Console.WriteLine($"{weapons[3].Name} добавлен в инвентарь!");
                    }
                }

                Console.WriteLine("Продолжить? \n1)продолжить \n2)прекратить");
                decision = Console.ReadLine();

                if (decision == "2")
                {
                    KeepCatchingObjects = false;
                }
            }
        }
    }
}