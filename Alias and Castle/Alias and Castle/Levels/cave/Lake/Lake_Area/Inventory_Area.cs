using System;
using System.Collections.Generic;

namespace Alias_and_Castle.Levels.cave.Lake.Lake_Area
{
    internal class Inventory_Area
    {
        public static void Inventory(List<MedKit> medKits, List<Weapon> weapons, List<LittleThings> littleThings,
            List<PlayerInventory> playerInventories, List<Catalog> catalog, ref bool beingNearALake) // Используем ref
        {
            bool exitInventory = false;

            while (!exitInventory)
            {
                Console.Clear();
                Console.WriteLine(" === ИНВЕНТАРЬ === ");
                Console.WriteLine("Выберите что просмотреть:");
                Console.WriteLine("1) Аптечки");
                Console.WriteLine("2) Оружие");
                Console.WriteLine("3) Прочее");
                Console.WriteLine("4) Выйти");

                string decision = Console.ReadLine();

                switch (decision)
                {
                    case "1":
                        ShowMedKits(medKits);
                        break;

                    case "2":
                        ShowWeapons(weapons);
                        break;

                    case "3":
                        ShowLittleThings(littleThings, ref beingNearALake, ref exitInventory);
                        break;

                    case "4":
                        exitInventory = true;
                        Console.WriteLine("Выход из инвентаря...");
                        System.Threading.Thread.Sleep(1000);
                        break;

                    default:
                        Console.WriteLine("Неверный выбор! Нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void ShowMedKits(List<MedKit> medKits)
        {
            Console.Clear();
            Console.WriteLine(" === АПТЕЧКИ === ");

            if (medKits == null || medKits.Count == 0)
            {
                Console.WriteLine("Аптечек нет");
            }
            else
            {
                int totalHealing = 0;
                Console.WriteLine("╔════╦══════════════════════════╦══════════╦══════════╦═══════╗");
                Console.WriteLine("║ №  ║ Название                 ║Количество║  Лечение ║  Цена ║");
                Console.WriteLine("╠════╬══════════════════════════╬══════════╬══════════╬═══════╣");

                for (int i = 0; i < medKits.Count; i++)
                {
                    var medKit = medKits[i];
                    totalHealing += medKit.Heals * medKit.Quantity;

                    Console.WriteLine($"║ {medKit.Index,-2} ║ {medKit.Size,-24} ║{medKit.Quantity,9} ║ {medKit.Heals,8} ║ {medKit.Price,5} ║");
                }

                Console.WriteLine("╚════╩══════════════════════════╩══════════╩══════════╩═══════╝");
                Console.WriteLine($"\nОбщее лечение: {totalHealing} HP");
            }

            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        private static void ShowWeapons(List<Weapon> weapons)
        {
            Console.Clear();
            Console.WriteLine(" === ОРУЖИЕ === ");

            if (weapons == null || weapons.Count == 0)
            {
                Console.WriteLine("Оружия нет");
            }
            else
            {
                foreach (var weapon in weapons)
                {
                    Console.WriteLine($"- {weapon.Name} (Урон: {weapon.Damage})");
                }
            }

            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        private static void ShowLittleThings(List<LittleThings> littleThings, ref bool beingNearALake, ref bool exitInventory)
        {
            bool exitLittleThings = false;

            while (!exitLittleThings)
            {
                Console.Clear();
                Console.WriteLine(" === ПРОЧИЕ ПРЕДМЕТЫ === ");

                if (littleThings == null || littleThings.Count == 0)
                {
                    Console.WriteLine("Предметов нет");
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    return;
                }

                for (int i = 0; i < littleThings.Count; i++)
                {
                    var item = littleThings[i];
                    Console.WriteLine($"{i + 1}) {item.Name} (x{item.Quantity})");
                }

                Console.WriteLine("\n0) Назад");
                Console.WriteLine("Выберите предмет для использования (или 0 для выхода):");

                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    exitLittleThings = true;
                    continue;
                }

                if (int.TryParse(choice, out int index) && index > 0 && index <= littleThings.Count)
                {
                    var selectedItem = littleThings[index - 1];

                    if (selectedItem.Name.Contains("кристал телепортации") || selectedItem.Name.Contains("телепорт"))
                    {
                        if (selectedItem.Quantity >= 1)
                        {
                            Console.WriteLine("\nИспользовать кристалл телепортации? (да/нет)");
                            string decision = Console.ReadLine();

                            if (decision.ToLower() == "да")
                            {
                                beingNearALake = false;
                                selectedItem.Quantity--;

                                if (selectedItem.Quantity <= 0)
                                {
                                    littleThings.RemoveAt(index - 1);
                                }

                                Console.WriteLine("Телепортация...");
                                Console.ReadKey();

                                exitLittleThings = true;
                                exitInventory = true;
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно кристаллов телепортации!");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\nВыбран предмет: {selectedItem.Name}");
                        Console.WriteLine("(Здесь может быть логика использования других предметов)");
                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Неверный выбор!");
                    Console.ReadKey();
                }
            }
        }
    }
}