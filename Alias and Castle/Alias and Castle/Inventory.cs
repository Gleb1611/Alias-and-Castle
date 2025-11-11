using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle
{
    internal class Inventory
    {
        public static void FightInventory(ref int littleHealsInInventory, ref int items, ref string nameCharacter, ref int changeMoveInFight, ref int heals, ref int littleHealsPosion, ref int maxHeals)
        {
            bool inventory = true;

            while (inventory)
            {
                Console.Clear();

                Console.WriteLine("=== ИНВЕНТАРЬ ===");

                if (littleHealsInInventory > 0)
                {
                    Console.WriteLine($"1) {littleHealsInInventory} малое зелье здоровья");
                }
                else
                {
                    Console.WriteLine("инвентарь пуст");
                    Console.ReadKey();
                }

                Console.WriteLine("0) Вернуться");
                Console.WriteLine("\nЧто использовать? ");
                items = int.Parse(Console.ReadLine());

                switch (items)
                {
                    case 0:
                        inventory = false;
                        changeMoveInFight = 1;
                        break;

                    case 1:
                        Console.WriteLine($"{nameCharacter} использовал моле зелье лечения и восстановил здоровье");
                        heals += littleHealsPosion;
                        littleHealsInInventory -= 1;
                        Console.ReadKey();
                        inventory = false;
                        changeMoveInFight = 0;

                        if(maxHeals < heals)
                        {
                            heals = maxHeals;
                        }
                        if(heals == maxHeals)
                        {
                            Console.Clear();
                            Console.WriteLine("Здоровье полность восстановлено");
                            Console.ReadKey();
                        }
                        break;

                    default:
                        Console.WriteLine("Неверный выбор");
                        break;
                }
            }
        }
    }
}
