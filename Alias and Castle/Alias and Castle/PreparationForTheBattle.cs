using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle
{
    internal class PreparationForTheBattle
    {
        public static void Fight(ref int healsEnemy, Random random, ref int heals, ref string weapon, ref int damageArm, ref int damage, ref int damageEneme, ref string nameCharacter, ref int littleHealsInInventory, ref int items, ref int littleHealsPosion, ref string enemy, ref int CreedDamegeEnemy, ref int maxHeals)
        {
            Console.Clear();
            Console.WriteLine("Бой начался!");
            Console.ReadKey();

            int changeInFight = 0;
            int changeMoveInFight = 0;


            while (healsEnemy > 0 && changeInFight != 4 && heals > 0)
            {
                Console.Clear();
                changeMoveInFight = 0;
                int randomCreedDamege = random.Next(0, 9);

                while (changeMoveInFight == 0)
                {
                    int i = 1;

                    Console.Clear();

                    Console.WriteLine("Вариация действий:");
                    Console.WriteLine($"{i++})Ударить рукой");
                    if(weapon != "рука")
                    {
                        Console.WriteLine($"{i++})Ударить {weapon}");
                    }
                    Console.WriteLine($"{i++})Просто стоять и бояться");
                    Console.WriteLine($"{i++})открыть инвентарь");
                    Console.WriteLine($"Выбор действия:");

                    if (int.TryParse(Console.ReadLine(), out changeInFight))
                    {
                        if(weapon == "рука")
                        {
                            if(changeInFight == 3 || changeInFight == 2)
                            {
                                changeInFight++;
                            }
                        }

                        switch (changeInFight)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Вы наносите удар по гоблину рукой\n");
                                healsEnemy -= damageArm;
                                Console.ReadKey();
                                changeMoveInFight = 1;
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine($"Вы ипользуете {weapon} нанести удар по {enemy}");
                                healsEnemy -= damage;
                                Console.ReadKey();
                                changeMoveInFight = 1;
                                break;

                            case 3:
                                Console.Clear();
                                Console.WriteLine("Вы ничего не делаете\n");
                                heals -= damageEneme;
                                Console.ReadKey();
                                changeMoveInFight = 1;
                                break;

                            case 4:
                                Console.Clear();
                                Console.WriteLine($"{nameCharacter} открыл инвентарь");
                                Console.ReadKey();


                                Inventory.FightInventory(ref littleHealsInInventory, ref items, ref nameCharacter, ref changeMoveInFight, ref heals, ref littleHealsPosion, ref maxHeals);


                                changeMoveInFight = 0;
                                break;

                            case 5:
                                Console.Clear();
                                Console.WriteLine("Вы сбежали ");
                                Console.ReadKey();
                                changeInFight = 4;
                                Console.ReadKey();
                                changeMoveInFight = 1;
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine("Неверный выбор");
                                break;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Пожалуйста, введите число!");
                        Console.ReadKey();
                    }
                }
                if (healsEnemy > 0 && changeInFight != 5 && heals > 0)
                {
                    switch (randomCreedDamege)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                            Console.Clear();
                            Console.WriteLine($"\n{enemy} бьёт вас");
                            heals -= damageEneme;
                            Console.WriteLine($"\n{enemy} наносит вам урона");
                            Console.ReadKey();
                            break;
                        case 8:
                        case 9:
                            Console.Clear();
                            Console.WriteLine($"\n{enemy} бьёт вас");
                            heals -= CreedDamegeEnemy;
                            Console.WriteLine($"\n{enemy} наносит вам {damageEneme} урона");
                            Console.ReadKey();
                            break;
                    }


                }



                Console.Clear();

                Console.WriteLine("=== Характеристики ===");

                Console.Clear();
                Console.WriteLine($"Характеристики {nameCharacter}");
                Console.WriteLine($"Здоровье: {heals}");

                Console.WriteLine($"\n=== Характеристики {enemy} ===");
                Console.WriteLine($"Здоровье: {healsEnemy}");
                Console.ReadKey();

            }

            if (healsEnemy <= 0)
            {
                Console.Clear();
                Console.WriteLine($"{nameCharacter} победил(а)");
                Console.ReadKey();
            }
            else if (heals <= 0)
            {
                Console.Clear();
                Console.WriteLine($"{nameCharacter} героически погиб");
                Console.ReadKey();
            }
            else if (healsEnemy <= 0)
            {
                Console.Clear();
                Console.WriteLine($"{nameCharacter} сбежал с поля боя, но остался жив");
                Console.ReadKey();
            }

            Console.Clear();

            Console.WriteLine("Бой окончен");
            Console.ReadKey();
        }
    }
}
