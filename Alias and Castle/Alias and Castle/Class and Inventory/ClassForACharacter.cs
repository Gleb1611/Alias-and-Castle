using System;
using System.Collections.Generic;

namespace Alias_and_Castle
{
    internal class ClassForACharacter
    {
        public static void ClassForCharacter(List<Class> classes, ref string race, ref int heals, ref int damageArm, ref int damage, ref int maxHeals, ref string nameCharacter, ref string weapon)
        {
            int chooceRace = 0;

            while (chooceRace == 0)
            {
                Console.Clear();

                int returnToChooceReace = 0;

                while (returnToChooceReace == 0)
                {
                    Console.Clear();

                    int i = 0;

                    foreach (var item in classes)
                    {
                        Console.WriteLine($"{i}){item.Name}");
                        i++;
                    }

                    Console.WriteLine("\nЧто выбирите? ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int raceInt))
                    {
                        Console.WriteLine("Ошибка: введите число!");
                        Console.ReadKey();
                        continue;
                    }

                    if (raceInt < 0 || raceInt >= classes.Count)
                    {
                        Console.WriteLine("Ошибка: неверный номер расы!");
                        Console.ReadKey();
                        continue;
                    }

                    var selectedClass = classes[raceInt];

                    Console.Clear();
                    Console.WriteLine($"=== {selectedClass.Name} ===");
                    Console.WriteLine($"\nЗдоровье - {selectedClass.Heals} \nСила - {selectedClass.Damage}");

                    Console.WriteLine("\n1) Подтвердить");
                    Console.WriteLine("0) Вернуться");

                    if (int.TryParse(Console.ReadLine(), out int acceptChoice))
                    {
                        switch (acceptChoice)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine($"Вы выбрали расу {selectedClass.Name}");




                                heals = selectedClass.Heals;
                                maxHeals = selectedClass.Heals;
                                damageArm = selectedClass.Damage;
                                race = selectedClass.Name;

                                /* Проверка присваивания характеристик для персонажа
                                Console.WriteLine($"ДО присваивания: maxHeals = {maxHeals}");
                                Console.WriteLine($"Значение в классе: MaxHeal = {classes[4].MaxHeal}");

                                Console.WriteLine($"ПОСЛЕ присваивания: maxHeals = {maxHeals}");
                                Console.WriteLine($"\n==={nameCharacter}===");
                                Console.WriteLine($"Здоровье: {heals}");
                                Console.WriteLine($"Максимальное здоровье: {maxHeals}");
                                Console.WriteLine($"Урон: {damageArm}");
                                Console.WriteLine($"Оружие: {weapon}");
                                */

                                Console.ReadKey();
                                chooceRace = 1;
                                returnToChooceReace = 1;
                                break;

                            case 0:
                                returnToChooceReace = 1;
                                break;

                            default:
                                Console.WriteLine("\nВведено неверное значение");
                                Console.ReadKey();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода!");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}