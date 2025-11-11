using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Alias_and_Castle
{
    internal class ClassForACharacter
    {
        public static void ClassForCharacter(ref string race, ref int heals, ref int damageArm, ref int damage, ref int maxHeals)
        {
            int chooceRace = 0;

            while (chooceRace == 0)
            {
                Console.Clear();

                int returnToChooceReace = 0;

                while (returnToChooceReace == 0)
                {
                    Console.Clear();

                    Console.WriteLine("Выбирете рассу вашего персонажа: ");
                    Console.WriteLine("1)Человек ");
                    Console.WriteLine("2)Эльф ");
                    Console.WriteLine("3)Гоблин ");
                    Console.WriteLine("4)Зверолюд ");
                    Console.WriteLine("5)Вампир ");
                    Console.WriteLine("\nЧто выбирите? ");
                    race = Console.ReadLine();

                    int raceInt = int.Parse(race);
                    int acceptChooce = 0;

                    switch (raceInt)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("=== Человек ===");
                            Console.WriteLine("\nЗдоровье - 100 \nСила -5");
                            race = "человек";

                            Console.WriteLine("\n1)Потвердить");
                            Console.WriteLine("0)Вернуться");


                            if (int.TryParse(Console.ReadLine(), out acceptChooce))
                            {
                                switch (acceptChooce)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine($"Вы выпбрали расу {race}");
                                        heals = 100;
                                        maxHeals = 100;
                                        damageArm = 5;
                                        Console.ReadKey();
                                        chooceRace = 1;
                                        returnToChooceReace = 1;
                                        break;

                                    case 0:
                                        chooceRace = 1;
                                        break;

                                    default:
                                        Console.WriteLine("\nВведено неверное значение");
                                        Console.ReadKey();
                                        break;
                                }
                            }

                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("=== Эльф ===");
                            Console.WriteLine("");
                            Console.WriteLine("\nЗдоровье - 100 \nСила - 9");

                            race = "Эльф";

                            Console.WriteLine("\n1)Потвердить");
                            Console.WriteLine("0)Вернуться");

                            acceptChooce = 0;

                            if (int.TryParse(Console.ReadLine(), out acceptChooce))
                            {
                                switch (acceptChooce)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine($"Вы выпбрали расу {race}");
                                        heals = 100;
                                        maxHeals = 100;
                                        damageArm = 9;
                                        Console.ReadKey();
                                        chooceRace = 1;
                                        returnToChooceReace = 1;
                                        break;

                                    case 0:
                                        chooceRace = 1;
                                        break;

                                    default:
                                        Console.WriteLine("\nВведено неверное значение");
                                        Console.ReadKey();
                                        break;
                                }
                            }

                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("=== Гоблин ===");
                            Console.WriteLine("\nЗдоровье - 90 \nСила - 5");
                            race = "Гоблин";

                            Console.WriteLine("\n1)Потвердить");
                            Console.WriteLine("0)Вернуться");

                            acceptChooce = 0;

                            if (int.TryParse(Console.ReadLine(), out acceptChooce))
                            {
                                switch (acceptChooce)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine($"Вы выпбрали расу {race}");
                                        heals = 90;
                                        maxHeals = 90;
                                        damage = 5;
                                        Console.ReadKey();
                                        chooceRace = 1;
                                        returnToChooceReace = 1;
                                        break;

                                    case 0:
                                        chooceRace = 1;
                                        break;

                                    default:
                                        Console.WriteLine("\nВведено неверное значение");
                                        Console.ReadKey();
                                        break;
                                }
                            }
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("=== Зверолюд ===");
                            Console.WriteLine("\nЗдоровье - 110 \nСила - 10");
                            race = "Зверолюд";

                            Console.WriteLine("\n1)Потвердить");
                            Console.WriteLine("0)Вернуться");

                            acceptChooce = 0;

                            if (int.TryParse(Console.ReadLine(), out acceptChooce))
                            {
                                switch (acceptChooce)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine($"Вы выпбрали расу {race}");
                                        heals = 110;
                                        maxHeals = 110;
                                        damageArm = 10;
                                        Console.ReadKey();
                                        chooceRace = 1;
                                        returnToChooceReace = 1;
                                        break;

                                    case 0:
                                        chooceRace = 1;
                                        break;

                                    default:
                                        Console.WriteLine("\nВведено неверное значение");
                                        Console.ReadKey();
                                        break;
                                }
                            }
                            break;

                        case 5:
                            Console.Clear();
                            Console.WriteLine("=== Вампир ===");
                            Console.WriteLine("");
                            Console.WriteLine("\nЗдоровье - 110 \nСила - 10");
                            race = "Вампир";

                            Console.WriteLine("\n1)Потвердить");
                            Console.WriteLine("0)Вернуться");

                            acceptChooce = 0;

                            if (int.TryParse(Console.ReadLine(), out acceptChooce))
                            {
                                switch (acceptChooce)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine($"Вы выпбрали расу {race}");
                                        heals = 110;
                                        maxHeals = 110;
                                        damageArm = 10;
                                        Console.ReadKey();
                                        chooceRace = 1;
                                        returnToChooceReace = 1;
                                        break;

                                    case 0:
                                        chooceRace = 1;
                                        break;

                                    default:
                                        Console.WriteLine("\nВведено неверное значение");
                                        Console.ReadKey();
                                        break;
                                }
                            }
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Введено не верное значение!");
                            Console.ReadKey();
                            break;
                    }
                }

            }
        }
    }
}
