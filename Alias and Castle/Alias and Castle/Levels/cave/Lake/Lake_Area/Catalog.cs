using System;
using System.Collections.Generic;
using System.Linq;

namespace Alias_and_Castle.Levels.cave.Lake.Lake_Area
{
    internal class Catalog_Area
    {
        public static void Buy(List<Catalog> catalog, List<LittleThings> littleThings, string decision)
        {
            if (catalog == null || catalog.Count == 0)
            {
                Console.WriteLine("Каталог пуст");
                return;
            }

            var coins = littleThings.FirstOrDefault(lt => lt.Name == "Монет");
            if (coins == null)
            {
                Console.WriteLine("У вас нет кошелька с монетами!");
                return;
            }

            Console.WriteLine($"\nВаш баланс: {coins.Quantity} монет");
            Console.WriteLine("\n=== КАТАЛОГ ===");

            for (int i = 0; i < catalog.Count; i++)
            {
                var item = catalog[i];
                Console.WriteLine($"{i}) {item.Name} - {item.Prise} монет (осталось: {item.Quantity})");
            }

            Console.WriteLine($"{catalog.Count}) Выйти из магазина");
            Console.WriteLine("\nСтарик: Что изволите купить? (введите номер товара)");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Неверный выбор!");
                return;
            }

            if (choice == catalog.Count)
            {
                Console.WriteLine("Старик: Возвращайтесь!");
                return;
            }

            if (choice < 0 || choice >= catalog.Count)
            {
                Console.WriteLine("Неверный выбор!");
                return;
            }

            var selectedItem = catalog[choice];

            if (selectedItem.Quantity <= 0)
            {
                Console.WriteLine($"Товар '{selectedItem.Name}' закончился!");
                return;
            }

            if (coins.Quantity < selectedItem.Prise)
            {
                Console.WriteLine($"Недостаточно монет! Нужно: {selectedItem.Prise}, у вас: {coins.Quantity}");
                return;
            }

            coins.Quantity -= (int)selectedItem.Prise;
            selectedItem.Quantity--;

            Console.WriteLine($"\nПокупка успешна!");
            Console.WriteLine($"Вы купили: {selectedItem.Name}");
            Console.WriteLine($"Потрачено: {selectedItem.Prise} монет");
            Console.WriteLine($"Осталось денег: {coins.Quantity} монет");
            Console.WriteLine($"Товара осталось: {selectedItem.Quantity}");

        }
    }
}