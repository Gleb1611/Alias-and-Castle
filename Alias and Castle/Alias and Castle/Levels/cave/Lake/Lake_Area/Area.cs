using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Alias_and_Castle.Levels.cave.Lake.Lake_Area
{
    internal class Area
    {
        public static void All(string nameCharacter, List<MedKit> medKits, List<Weapon> weapons,
            List<LittleThings> littleThings, List<PlayerInventory> playerInventories, List<Catalog> catalog, int damage, int heals, string weapon, string decision, Random random)
        {
            bool beingNearALake = true;

            while (beingNearALake)
            {
                Console.Clear();

                Console.WriteLine("1) Костёр");
                Console.WriteLine("2) Озеро");
                Console.WriteLine("3) Лавка старика");

                decision = Console.ReadLine();

                switch (decision)
                {
                    case "1":
                        Inventory_Area.Inventory(medKits, weapons, littleThings, playerInventories, catalog, ref beingNearALake);
                        break;

                    case "2":
                        Console.Clear();

                        LakeCoins.Lake(nameCharacter, medKits, weapons,
                            littleThings, playerInventories, damage, heals, weapon, decision, random);
                        break;

                    case "3":
                        Console.Clear();

                        Catalog_Area.Buy(catalog, littleThings, decision);

                        break;
                }
            }
        }
    }
}
