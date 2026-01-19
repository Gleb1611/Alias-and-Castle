using Alias_and_Castle.Levels;
using Alias_and_Castle.Levels.cave.Lake;
using Alias_and_Castle.Levels.cave.Lake.Lake_Area;
using Alias_and_Castle.Levels.cave.Lake.Lake_Area;
using Alias_and_Castle.Levels.Towers;
using Alias_and_Castle.Levels.cave.Lake.Lake_Area;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Alias_and_Castle.Levels.Exit;

namespace Alias_and_Castle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Alias and Castle";

            int lockWhitLengthKey = 5;
            bool lockFire = false;
            bool rockLock = false;
            int timer = 0;

            //Вызов классов 
            List<Class> classes = new List<Class>
            {
                new Class{ Index = 0, Name ="Человек", Heals = 100, Damage = 8},
                new Class{ Index = 1, Name ="Эльф", Heals = 100, Damage = 7},
                new Class{ Index = 2, Name ="Гоблин", Heals = 80, Damage = 5},
                new Class{ Index = 3, Name ="Зверолюд", Heals = 110, Damage = 10},
                new Class{ Index = 4, Name ="Вампир", Heals = 110, Damage = 10},
            };

            List<Weapon> weapons = new List<Weapon>
            {
                new Weapon { Index = 1, Name = "Палка", Damage = 8, CreatRate = 5, CreatDamage = 11,},
                new Weapon { Index = 2, Name = "Тупой меч", Damage = 15, CreatRate = 20, CreatDamage = 25,},
                new Weapon { Index = 3, Name = "Меч", Damage = 30, CreatRate = 20, CreatDamage = 40,},
                new Weapon { Index = 4, Name = "Кинжал", Damage = 16, CreatRate = 20, CreatDamage = 30 },
            };

            List<MedKit> medKits = new List<MedKit>
            {
                new MedKit { Index = 1, Size = "Маленькая аптечка", Quantity = 1, Heals = 5, Price = 2},
                new MedKit { Index = 2, Size = "Средняя аптечка", Quantity = 1, Heals = 10, Price = 4},
                new MedKit { Index = 3, Size = "Большая аптечка", Quantity = 1, Heals = 20, Price = 5},
            };

            List<LittleThings> littleThings  = new List<LittleThings>
            {
                new LittleThings { Index = 1, Name = "Монет", Quantity = 0},
                new LittleThings { Index = 2, Name = "Кристал телепортации", Quantity = 0},
            };

            List<PlayerInventory> playerInventories = new List<PlayerInventory>
            {

            };

            List<Catalog> catalog = new List<Catalog>
            {
                new Catalog { Index = 0, Name = "Маленькая аптечка", Prise = 10, Quantity = 15},
                new Catalog { Index = 1, Name = "Средняя аптечка", Prise = 20, Quantity = 10},
                new Catalog { Index = 2, Name = "Большая аптечка", Prise = 35, Quantity = 5},
                new Catalog { Index = 3, Name = "Стальной шлем", Prise = 100, Quantity = 1},
                new Catalog { Index = 4, Name = "Меч", Prise = 350, Quantity = 1},
                new Catalog { Index = 5, Name = "Кристал телепортации", Prise = 10000, Quantity = 1},
            };


        int mood = 70;
            bool luck = true;
            bool holeInBackpack = false;

            // Дефолтное состояние персонажа
            string nameCharacter = "Alias";
            string race = "человек";
            int heals = 100;
            int maxHeals = 100;
            int coin = 0;
            string weapon = "рука";
            int damageArm = 5;
            int damage = 5;


            //Дефолтное состояние оружия
            string sword = "ржавый меч";
            string stick = "палка";

            int littleHealsInInventory = 2;

            int towerTimerOne = 1;
            int towerTimerTwo = 1;
            int towerTimerThree = 1;

            int artifact = 0;
            int items = 0;

            int littleHealsPosion = 5;
            int mediumHealsPosion = 10;
            int bigeHealsPosion = 20;
            int NumberOfArtifacts = 0;


            string decision = "";

            Random random = new Random();

            Console.ForegroundColor = ConsoleColor.White;

            

            TootorialBeforGame.Totorial();



            Console.Clear();


            Console.WriteLine("Внимание!");
            Console.WriteLine("Это не финальная версия");
            Console.WriteLine("В ней могут присуствовать ошибки и опечатки");
            Console.ReadKey();


            ClassForACharacter.ClassForCharacter(classes, ref race, ref heals, ref damageArm, ref damage, ref maxHeals, ref nameCharacter, ref weapon);

            Console.Clear();


            Console.Write("Введите имя своего персонажа: ");
            nameCharacter = Console.ReadLine();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"=== Предыстория ===\n {nameCharacter}, молодой(ая) иследователь, слышал легенды о замке Эльдора, где храниться Кристал Вечной Мудрости. " +
                "После месяцев поисков он нашёл скрытый вход в горной пещере");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine($"{nameCharacter}: Может не стоит входить туда?");
            Console.WriteLine("Войти? (да / нет)");
            string enterTheCave = Console.ReadLine();

            Console.Clear();

            if (enterTheCave.ToLower() == "да" || enterTheCave.ToLower() == "д" || enterTheCave.ToLower() == "а")
            {

                Console.WriteLine("В пещере темно \nЗажечь свечу? (да / нет)");
                decision = Convert.ToString(Console.ReadLine());

                if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                {
                    Console.WriteLine(nameCharacter + " Зажёг свечу. \n" + nameCharacter + " спокойно спустился");
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine($"Сделав шаг {nameCharacter} упал в глубокую пропасть и потратил(а) здоровье");
                    Console.ReadKey();
                    Console.WriteLine("-10 здоровье");

                    heals -= 10;

                    Console.ReadKey();
                    Console.WriteLine($"{nameCharacter} зажёг свечу");
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.WriteLine("После спуска " + nameCharacter + " увидел(а) перед собой табличку, а за ней три монумента");
                Console.ReadKey();
                Console.WriteLine("\nНа табличке написано: ");
                Console.WriteLine("\nТолько лишь достойный сможет активировать три ионумента и открыть проход ведущую в грабницу с сокровещами");
                Console.ReadKey();

                ChangeTowers.MainChange(weapons,towerTimerOne, towerTimerTwo, towerTimerThree, NumberOfArtifacts, decision, damage, weapon, heals, timer, items, stick, sword, luck, nameCharacter, mood, littleHealsInInventory, damageArm, littleHealsPosion, holeInBackpack, artifact, ref maxHeals);

                if(NumberOfArtifacts == 1)
                {
                    Console.Clear();

                    FallingToTheVeryBottom.Liana(nameCharacter, decision, random, heals, damage, medKits, weapons, littleThings, playerInventories, weapon);

                    LakeWhithCoins.lakeAndShop( nameCharacter, medKits, weapons,
                    littleThings, playerInventories, catalog, damage, heals, weapon);
                }

                Console.Clear();


                Area.All( nameCharacter, medKits, weapons,
                littleThings, playerInventories, catalog, damage, heals, weapon, decision, random);

                Console.Clear();

                Console.WriteLine($"{nameCharacter} попал(а) в неизвестную пещеру, где был загадоочный рисунок");
                Console.WriteLine("Посмотреть рисунок? (да/нет)");
                decision = Console.ReadLine();

                int capture = random.Next(3, 19);

                Console.Clear();

                switch (decision.ToLower())
                {
                    case "да":
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.White;

                        for (int i = 1; i < capture; i++)
                        {
                            Console.Write($"{i} ");
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine("");
                        }
                        break;

                    case "нет":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine($"{nameCharacter}: Красивый рисунок, но мне надо идти дальше");
                        break;
                }

                Console.Clear();
                Console.WriteLine($"Пройдя дальше {nameCharacter} увидел(а) дверь, на ней есть рисунок");
                Console.ReadKey();

                Console.WriteLine($"{nameCharacter}, подмечает, что этот рисунок похож на тот, который {nameCharacter} видел(а) на стене ранее");
                Console.Clear();

                Console.WriteLine($"{nameCharacter} вернулся(лась) обратно к рисунку");
                Console.ReadKey();

                Console.Clear();


                for (int i = 1; i < capture; i++)
                {
                    Console.Write($"{i} ");
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }

                Console.ReadKey();

                bool finalDoors = true;

                while (finalDoors)
                {
                    FirstFinalDoor.FirstDoor(nameCharacter, decision, capture);

                    SecondFinalDoor.SecondDoor(nameCharacter, decision);

                    LasFinalDoor.LastDoor(nameCharacter, decision, finalDoors);

                }

                Console.Clear();

                Console.WriteLine($"Ну всё,{nameCharacter} выбрался(лась) из замка");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{nameCharacter}: Думаю не стоит");
                Console.ReadKey();
            }

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Конец игры!");
            Console.ReadKey();
        }

        public static void spiderGame(string nameCharacter)
        {

        }



    }
}