using System;

namespace Alias_and_Castle.Levels.Exit
{
    internal class LasFinalDoor
    {
        public static void LastDoor(string nameCharacter, string decision, bool finalDoors)
        {
            try
            {
                Console.WriteLine("Введите число до которого будут выполнены вычисления:");
                int limit = GetPositiveIntegerInput();

                Console.WriteLine("Введите число умножения:");
                int multiplier = GetPositiveIntegerInput();

                Console.WriteLine($"\nТаблица умножения числа {multiplier} до {limit}:");
                Console.WriteLine(new string('-', 30));

                int sum = 0;
                for (int i = 1; i <= limit; i++)
                {
                    sum = i * multiplier;
                    Console.WriteLine($"{i} * {multiplier} = {sum}");
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();

                finalDoors = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.ReadKey();
            }
        }

        private static int GetPositiveIntegerInput()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    if (result > 0)
                        return result;
                    else
                        Console.WriteLine("Пожалуйста, введите положительное число:");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число:");
                }
            }
        }
    }
}