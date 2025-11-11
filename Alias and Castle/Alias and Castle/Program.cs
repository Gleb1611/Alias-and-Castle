using Alias_and_Castle.Towers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            int heals = 100;
            int maxHeals = 100;
            int mood = 70;
            bool luck = true;
            bool holeInBackpack = false;

            int damageArm = 5;
            string race = "человек";
            string weapon = "рука";
            int damage = 5;

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

            

            //Totorial();

            Console.Clear();


            Console.WriteLine("Внимание!");
            Console.WriteLine("Это не финальная версия");
            Console.WriteLine("В ней могут присуствовать ошибки и опечатки");
            Console.ReadKey();

            //ClassForACharacter.ClassForCharacter(ref race, ref heals, ref damageArm, ref damage);

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
                string decision = "";

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

        public static void Totorial()
        {
            Console.WriteLine("Обучение\n" +
               "Для продолжения нажмите Enter ");

            Console.ReadKey();

            Console.WriteLine("Для выбора действия введите число, затем нажмите Enter ");
            Console.ReadKey();
            string traningNumber = "";
            int checkingTheEnteredNumberInTraining = 0;

            while (checkingTheEnteredNumberInTraining == 0)
            {
                Console.Clear();

                Console.WriteLine("Пример:");
                Console.WriteLine("Выбирите действие:");

                checkingTheEnteredNumberInTraining = 0;
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"{i})действие");
                }
                Console.WriteLine("\nВы должны ввести любое число из списка");
                traningNumber = Console.ReadLine();

                switch (traningNumber)
                {
                    case "1":
                    case "2":
                    case "3":
                        checkingTheEnteredNumberInTraining = 1;
                        break;
                    default:
                        Console.Clear();

                        Console.WriteLine("\nВы ввели недоступное число");
                        Console.ReadKey();

                        Console.Clear();
                        break;
                }
            }
            Console.Clear();

            Console.WriteLine("Если вы видите (да / нет), то вам следует ввести да или нет");
            Console.ReadKey();


            for (int i = 1; i < 3;)
            {
                while (i <= 3)
                {
                    switch (i)
                    {
                        case 1:
                            Console.Clear();

                            Console.WriteLine("Пример:\n");

                            Console.WriteLine("Следует ли вовремя делать домашнее задание? (да / нет):");
                            traningNumber = Console.ReadLine();
                            if (traningNumber.ToLower() == "да" || traningNumber.ToLower() == "д" || traningNumber.ToLower() == "а")
                            {
                                Console.WriteLine("Правильно! Давай перейдём к следующему заданию");
                                i++;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Не верно, попробуй ещё раз");
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Вы добровольно играете в эту игру, (да / нет):");
                            traningNumber = Console.ReadLine();
                            if (traningNumber.ToLower() == "да" || traningNumber.ToLower() == "д" || traningNumber.ToLower() == "а")
                            {
                                Console.WriteLine("Правильно! Давай перейдём к следующему заданию");
                                i++;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Не верно, попробуй ещё раз");
                                Console.ReadKey();
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Вы одни в комнате? (да / нет):");
                            traningNumber = Console.ReadLine();
                            if (traningNumber.ToLower() == "да" || traningNumber.ToLower() == "д" || traningNumber.ToLower() == "а")
                            {
                                Console.Clear();
                                Console.WriteLine("Не верно, попробуй ещё раз");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Правильно!");
                                i++;
                                checkingTheEnteredNumberInTraining = 1;
                            }
                            break;
                    }
                }

            }

            Console.Clear();

            Console.WriteLine("Поздравляю, вы прошли всё обучение(которое есть на данный момент)");
            Console.ReadKey();
        }

        

        public static void ArtefactsRoom(string nameCharacter, int heals, bool luck, int artifact, int mood, bool holeInBackpack, int NumberOfArtifacts, string decision)
        {
            if (heals >= 1)
            {
                Console.Clear();

                Console.WriteLine($"Активировав все монументы {nameCharacter} слышит грохочещий звук");
                Console.ReadKey();
                Console.WriteLine("За монументом по середине появляется проход");
                Console.ReadKey();

                Console.Clear();

                Console.WriteLine($"Войдя в таинственный проход {nameCharacter} видит дверь");
                Console.ReadKey();
                Console.WriteLine("На двери написано");
                Console.WriteLine("Кажды вся суда входящий, должен быть чист сердцем и душой");
                Console.ReadKey();

                Console.Clear();

                Console.WriteLine($"{nameCharacter}  проходить в Загадочный проход\n");

                Console.WriteLine("1)Шляпа Колдуна( -40 здоровья, +30 настроение, -удача ) ");

                Console.WriteLine("2)Кубок Бессмертия( 150 здоровья, -20 настроения, +удача, )");

                Console.WriteLine("3)Сердце Феникса( +100 здоровья, +15 настроения, +удача, ремонт рюкзака )");

                Console.WriteLine("4)Плащ Теней( -10 здоровья, +15 настроения, -удача)");

                Console.WriteLine("5)Слеза Королевы( +40 здоровья , 100 настроения, -удача, повреждение рюкзака )");

                Console.WriteLine("6)Посох Студента( -20 здоровья, +35 настроения, +удача)");

                Console.WriteLine("7)Коготь Дракона( +30 здоровья, +10 настроения, +удача, повреждение рюкзака )");

                Console.WriteLine("8)Зеркало Прошлого( -15 здоровья, -10 настроения, +удача)");

                Console.WriteLine("9)Сапоги Странника( +20 здоровья, +30 настроения, -удача, повреждение рюкзака");

                Console.WriteLine("10)Ничего не брать( +0 здоровья, +0 настроения, удача( неизменно )");

                Console.WriteLine($"\n{ nameCharacter}: Что мне взять?");
                artifact = int.Parse(Console.ReadLine());

                Console.Clear();



                switch (artifact)
                {
                    case 1:
                        Console.WriteLine($"{nameCharacter} берёт Шляпа Колдуна");
                        heals -= 40;
                        mood += 30;
                        luck = false;
                        holeInBackpack = false;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts += 1;
                        break;
                    case 2:
                        Console.WriteLine($"{nameCharacter} берёт Кубок Бессмертия");
                        heals = 150;
                        mood -= 20;
                        luck = true;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts += 1;
                        break;
                    case 3:
                        Console.WriteLine($"{nameCharacter} берёт Сердце Феникса");
                        heals += 10;
                        mood += 25;
                        luck = true;
                        holeInBackpack = true;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts += 1;
                        break;
                    case 4:
                        Console.WriteLine($"{nameCharacter} берёт Плащ Теней");
                        heals -= 10;
                        mood += 15;
                        luck = true;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts += 1;
                        break;
                    case 5:
                        Console.WriteLine($"{nameCharacter} берёт Слеза Королевы");
                        heals -= 40;
                        mood = 100;
                        luck = false;
                        holeInBackpack = true;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts += 1;
                        break;
                    case 6:
                        Console.WriteLine($"{nameCharacter} берёт Посох Студента");
                        heals -= 20;
                        mood += 35;
                        luck = false;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts += 1;
                        break;
                    case 7:
                        Console.WriteLine($"{nameCharacter} берёт Коготь Дракона");
                        heals += 30;
                        mood += 10;
                        luck = true;
                        holeInBackpack = true;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts += 1;
                        break;
                    case 8:
                        Console.WriteLine($"{nameCharacter} берёт Зеркало Прошлого");
                        heals -= 15;
                        mood -= 10;
                        luck = true;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts += 1;
                        break;
                    case 9:
                        Console.WriteLine($"{nameCharacter} берёт Сапоги Странника");
                        heals += 20;
                        mood -= 20;
                        luck = true;
                        holeInBackpack = true;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts += 1;
                        break;
                    case 10:
                        Console.WriteLine($"{nameCharacter} решает ничего не брать");

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Вы ввели недоступное число");
                        break;
                }

                if (NumberOfArtifacts >= 1)
                {
                    Console.WriteLine(nameCharacter + " хочет забрать всё. \nЗабрать всё? (да / нет)");
                    decision = Convert.ToString(Console.ReadLine());

                    if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                    {
                        Console.Clear();

                        Console.WriteLine($"{nameCharacter} берёт все сокровища из сокровещницы, но выйдя из грабницы {nameCharacter} чуствует боль в груди, падает на землю и хватается за грудь");
                        Console.ReadKey();
                        Console.WriteLine("\nСпустя несколь лет, новые искатели находят тело неизвесного человека");
                        Console.ReadKey();
                    }
                }
            }
        }


    }
}

