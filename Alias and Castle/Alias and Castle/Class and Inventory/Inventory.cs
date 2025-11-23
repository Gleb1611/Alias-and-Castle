using System;
using System.Collections.Generic;
using System.Linq;

namespace Alias_and_Castle
{
    internal class Inventory
    {
        public static void FightInventory(ref List<MedKit> medKits, ref int items, ref string nameCharacter,
            ref int changeMoveInFight, ref int heals, ref int littleHealsPosion, ref int maxHeals, ref int littleHealsInInventory)
        {
            bool inventory = true;

            while (inventory)
            {
                Console.Clear();
                Console.WriteLine("=== ИНВЕНТАРЬ ===");

                bool hasItems = false;

                foreach (var item in medKits)
                {
                    if (item.Quantity != 0)
                    {
                        Console.WriteLine($"{item.Index}) {item.Size} ({item.Quantity})");
                        hasItems = true;
                    }
                }

                if (!hasItems)
                {
                    Console.WriteLine("инвентарь пуст");
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    inventory = false;
                    changeMoveInFight = 1;
                    continue;
                }

                Console.WriteLine("0) Вернуться");
                Console.WriteLine("\nЧто использовать? ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Неверный ввод! Нажмите любую клавишу...");
                    Console.ReadKey();
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        inventory = false;
                        changeMoveInFight = 1;
                        break;

                    case 1:
                    case 2:
                    case 3:
                        UseMedKit(choice, medKits, ref nameCharacter, ref heals, ref maxHeals, ref changeMoveInFight);
                        inventory = false;
                        break;

                    default:
                        Console.WriteLine("Неверный выбор! Нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void UseMedKit(int choice, List<MedKit> medKits, ref string nameCharacter,
            ref int heals, ref int maxHeals, ref int changeMoveInFight)
        {
            var selectedItem = medKits.FirstOrDefault(item => item.Index == choice);

            if (selectedItem == null || selectedItem.Quantity <= 0)
            {
                Console.WriteLine("Предмет не найден или закончился!");
                Console.ReadKey();
                return;
            }

            if (heals > maxHeals)
            {
                Console.Clear();
                Console.WriteLine($"Здоровье {nameCharacter} восстановлено полностью и не требует использования {selectedItem.Size}");
                Console.ReadKey();
                return;
            }

            Console.Clear();
            Console.WriteLine($"{nameCharacter} использовал {selectedItem.Size} и восстановил здоровье");

            heals += selectedItem.Heals;
            selectedItem.Quantity -= 1;
            changeMoveInFight = 0;

            if (heals >= maxHeals)
            {
                heals = maxHeals;
            }

            Console.WriteLine($"Текущее здоровье: {heals}/{maxHeals}");
            Console.ReadKey();
        }
    }
}