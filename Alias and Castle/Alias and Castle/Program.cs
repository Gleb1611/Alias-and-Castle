using Alias_and_Castle.Levels;
using Alias_and_Castle.Levels.Towers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Alias_and_Castle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Alias and Castle";
            string nameCharacter = "Alias";

            int lockWhitLengthKey = 5;
            bool lockFire = false;
            bool rockLock = false;
            int timer = 0;



            int mood = 70;
            bool luck = true;
            bool holeInBackpack = false;

            // Дефолтное состояние персонажа
            string race = "человек";
            int heals = 100;
            int maxHeals = 100;
            string weapon = "рука";
            int damageArm = 5;
            int damage = 5;


            //Дефолтное состояние оружия
            string sword = "ржавый меч";
            string stick = "палка";

            int littleHealsInInventory = 2;

            int towerTimerOne = 0;
            int towerTimerTwo = 0;
            int towerTimerThree = 0;

            int artifact = 0;
            int items = 0;

            int littleHealsPosion = 5;
            int mediumHealsPosion = 10;
            int bigeHealsPosion = 20;
            int NumberOfArtifacts = 0;


            string decision = "";

            Random random = new Random();
            //TootorialBeforGame.Totorial();

            Console.Clear();


            Console.WriteLine("Внимание!");
            Console.WriteLine("Это не финальная версия");
            Console.WriteLine("В ней могут присуствовать ошибки и опечатки");
            Console.ReadKey();


            List<Class> classes = new List<Class>
            {
                new Class{ Index = 0, Name ="Человек", Heals = 100, Damage = 8},
                new Class{ Index = 1, Name ="Эльф", Heals = 100, Damage = 7},
                new Class{ Index = 2, Name ="Гоблин", Heals = 80, Damage = 5},
                new Class{ Index = 3, Name ="Зверолюд", Heals = 110, Damage = 10},
                new Class{ Index = 4, Name ="Вампир", Heals = 110, Damage = 10},
            };


            ClassForACharacter.ClassForCharacter(classes, ref race, ref heals, ref damageArm, ref damage, ref maxHeals, ref nameCharacter, ref weapon);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Введите имя своего персонажа: ");
            nameCharacter = Console.ReadLine();

            Console.Clear();

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

                ChangeTowers.MainChange(towerTimerOne, towerTimerTwo, towerTimerThree, NumberOfArtifacts, decision, damage, weapon, heals, timer, items, stick, sword, luck, nameCharacter, mood, littleHealsInInventory, damageArm, littleHealsPosion, holeInBackpack, artifact, ref maxHeals);

                if(NumberOfArtifacts == 1)
                {

                }

                Console.Clear();
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
        public static void LakeWithCoins(string nameCharacter, string decision, Random random, int heals, List<MedKit> medKit, List<Weapon> weapon, List<LittleThings> littleThings)
        {
            Console.Clear();


            Console.WriteLine($"Возвращаясь к выходу {nameCharacter} насступает на камень и пол проваливается");
            Console.ReadKey();
            Console.WriteLine($"{nameCharacter} успел схватиться за лиану");
            Console.WriteLine($"{nameCharacter}: куда полсти? \n1)Вверх \n2)Вниз");
            decision = Console.ReadLine();

            switch(decision)
            {
                case "1":
                    for(int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"{nameCharacter} ползёт вверх");

                        MovingUpTheCreeper(random, nameCharacter, heals, decision, medKit, weapon, littleThings);
                    }
                    break;
                case "2":
                    for(int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"{nameCharacter} ползёт вниз");

                        MovingUpTheCreeper(random, nameCharacter, heals, decision, medKit, weapon, littleThings);
                    }
                    break;
            }
        }
        public static void MovingUpTheCreeper(Random random, string nameCharacter, int heals, string decision, List<MedKit> medKit, List<Weapon> weapon, List <LittleThings> littleThings)
        {

            int randomEvent = random.Next(0, 2);

            switch(randomEvent)
            {
               case 0:
                    Console.Clear();

                    Console.WriteLine($"ничего не произолшло и {nameCharacter} ползёёт дальше");
                    Console.ReadKey();
                    break;
                case 1:
                    Console.Clear();

                    Console.WriteLine($"{nameCharacter} нашёл рюкзак");

                    Console.Clear();

                    BackpackRandomItems.backPackRandomItem(medKit, littleThings, nameCharacter, random, decision);
            break;
                case 2:
                    Console.Clear();
                    Console.WriteLine($"{nameCharacter} укололся шипом от лианы \n -5 здоровья");
                    heals -= 5;
                    break;
            }
        }

        public static void spiderGame(string nameCharacter)
        {

        }
    }
}

