using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
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
            int mood = 70;
            bool luck = true;
            bool holeInBackpack = false;
            int damageArm = 5;
            string race = "человек";
            int littleHealsInInventory = 0;


            int artifact = 0;
            int items = 0;

            int littleHealsPosion = 5;
            int mediumHealsPosion = 10;
            int bigeHealsPosion = 20;

            string weapon = "рука";
            int damage = 5;
            string sword = "ржавый меч";
            string stick = "палка";

            

            int chooceRace = 0;

            while(chooceRace == 0)
            {
                Console.Clear();

                int returnToChooceReace = 0;
                
                while(returnToChooceReace == 0)
                {
                    Console.Clear();

                    Console.WriteLine("Выбирете рассу вашего персонажа: ");
                    Console.WriteLine("1)Человек ");
                    Console.WriteLine("2)Эльф ");
                    Console.WriteLine("3)Гоблин ");
                    Console.WriteLine("4)Зверолюд ");
                    Console.WriteLine("5)Вампир ");
                    Console.WriteLine("\nЧто выбирите? ");
                    race = Convert.ToString(Console.ReadLine());

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

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Введите имя своего персонажа: ");
            nameCharacter = Convert.ToString(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Предыстория:\n " + nameCharacter + ", молодой(ая) иследователь, слышал легенды о замке Эльдора, где храниться Кристал Вечной Мудрости. " +
                "После месяцев поисков он нашёл скрытый вход в горной пещере");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine(nameCharacter + ": Может не стоит входить туда?");
            Console.WriteLine("Войти? (да / нет)");
            string enterTheCave = Convert.ToString(Console.ReadLine());

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

                    Console.WriteLine("Сделав шаг " + nameCharacter + " упал в глубокую пропасть и потратил(а) здоровье");
                    Console.ReadKey();
                    Console.WriteLine("-10 здоровье");

                    heals -= 10;

                    Console.ReadKey();
                    Console.WriteLine(nameCharacter + " зажёг свечу");
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.WriteLine("После спуска " + nameCharacter + " увидел(а) перед собой табличку, а за ней три монумента");
                Console.ReadKey();
                Console.WriteLine("\nНа табличке написано: ");
                Console.WriteLine("\nТолько лишь достойный сможет активировать три ионумента и открыть проход ведущую в грабницу с сокровещами");
                Console.ReadKey();

                Console.Clear();

                Console.WriteLine(nameCharacter + " подошёл(шла) к первому монументу. \nТам было углубление для ключа ");
                Console.ReadKey();
                Console.WriteLine("Попробовать свой ключ от дома? (да / нет)");
                decision = Convert.ToString(Console.ReadLine());

                if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                {
                    Console.Clear();


                    Console.WriteLine(nameCharacter + " достает маленький ржавый ключ и пытается поставить его\n");
                    Console.ReadKey();
                    Console.WriteLine("*глухой звук*\n");
                    Console.ReadKey();
                    Console.WriteLine("Ключ недостаточно мудр...\n");
                    Console.WriteLine("Попробовать ещё? (да / нет)");
                    decision = Convert.ToString(Console.ReadLine());

                    Console.Clear();

                    if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                    {
                        Console.WriteLine(nameCharacter + " попробовал(а) с силой поставить ключ, но ничего не получилось\n");
                        Console.ReadKey();
                        Console.WriteLine("Попробовать ещё? (да / нет) ");
                        decision = Convert.ToString(Console.ReadLine());

                        Console.Write(decision);

                        if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                        {
                            Console.WriteLine(nameCharacter + " попробовал(а) с силой поставить ключ \nКлюч встал,но " + nameCharacter + " повредил(а) руку");
                            Console.WriteLine("Здоровье и настроение " + nameCharacter + " снизилось");
                            Console.ReadKey();

                            heals -= 10;
                            mood -= 25;

                            Console.WriteLine($"Характеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood}\n");
                            Console.ReadKey();
                            timer += 1;
                        }
                        else
                        {
                            Console.WriteLine("Немного осмотревшись " + nameCharacter + " замечает, что что-то блестит за монументом в кустах\n");
                            Console.ReadKey();
                            Console.WriteLine("Осмотреть куст? (да / нет)");
                            decision = Convert.ToString(Console.ReadLine());

                            if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                            {
                                Console.WriteLine("Осмотрев кус, " + nameCharacter + " подмечает, что это крапива\n");
                                Console.ReadKey();
                                Console.WriteLine("На дне крапивы лежит ключ\n");
                                Console.WriteLine("Взять ключ?({0} получит ожог руки)\n (да / нет)", nameCharacter);
                                decision = Convert.ToString(Console.ReadLine());

                                if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                                {
                                    Console.WriteLine(nameCharacter + " взял(а) ключ, но получил(а) ожог руки");
                                    Console.ReadKey();
                                    Console.WriteLine("-5 Здоровья");
                                    heals -= 5;
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine(nameCharacter + " решает осмотреться");
                                    Console.ReadKey();
                                    Console.WriteLine(nameCharacter + " нашёл(шла) несколько предметов");
                                    Console.ReadKey();
                                    Console.WriteLine("1) Палка");
                                    Console.WriteLine("2) Тупой меч");
                                    Console.WriteLine(nameCharacter + ": Что взять?");
                                    items = int.Parse(Console.ReadLine());

                                    switch (items)
                                    {
                                        case 1:
                                            Console.WriteLine(nameCharacter + " взял(а) палку");
                                            damage = 8;
                                            weapon = stick;
                                            luck = true;
                                            Console.WriteLine($"Урон = {damage}");
                                            Console.ReadKey();

                                            break;

                                        case 2:
                                            Console.WriteLine(nameCharacter + " взял(а) меч");
                                            damage = 20;
                                            weapon = sword;
                                            luck = false;
                                            Console.WriteLine($"Урон = {damage}");
                                            Console.ReadKey();

                                            break;
                                    }
                                    Console.WriteLine(nameCharacter + " решает использовать " + weapon + ", чтобы убрать крапиву и достать ключ");
                                    Console.ReadKey();
                                    Console.WriteLine(nameCharacter + " использовал(а) ключ, чтобы активировать монумент");
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                Console.WriteLine(nameCharacter + " решает осмотреться");
                                Console.ReadKey();
                                Console.WriteLine(nameCharacter + " нашёл(шла) несколько предметов");
                                Console.ReadKey();
                                Console.WriteLine("1) Палка");
                                Console.WriteLine("2) Тупой меч");
                                Console.WriteLine(nameCharacter + ": Что взять?");
                                items = int.Parse(Console.ReadLine());

                                switch (items)
                                {
                                    case 1:
                                        Console.WriteLine(nameCharacter + " взял(а) палку");
                                        damage = 8;
                                        weapon = stick;
                                        luck = true;
                                        Console.WriteLine($"Урон = {damage}");
                                        Console.ReadKey();

                                        break;

                                    case 2:
                                        Console.WriteLine(nameCharacter + " взял(а) меч");
                                        damage = 20;
                                        weapon = sword;
                                        luck = false;
                                        Console.WriteLine($"Урон = {damage}");
                                        Console.ReadKey();

                                        break;
                                }
                                Console.WriteLine(nameCharacter + " решает использовать " + weapon + ", чтобы убрать крапиву и достать ключ");
                                Console.ReadKey();
                                Console.WriteLine(nameCharacter + " использовал(а) ключ, чтобы активировать монумент");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Немного осмотревшись " + nameCharacter + " замечает, что что-то блестит за монументом в кустах");
                        Console.ReadKey();
                        Console.WriteLine("Осмотреть куст? (да / нет)");
                        decision = Convert.ToString(Console.ReadLine());

                        if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                        {
                            Console.WriteLine("Осмотрев кус, " + nameCharacter + " подмечает, что это крапива");
                            Console.ReadKey();
                            Console.WriteLine("На дне крапивы лежит ключ\n");
                            Console.WriteLine("Взять ключ?({0} получит ожог руки)\n (да / нет)", nameCharacter);
                            decision = Convert.ToString(Console.ReadLine());

                            if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                            {
                                Console.WriteLine(nameCharacter + " взял(а) ключ, но обожгл(а) руку");
                                Console.ReadKey();
                                Console.WriteLine("-5 Здоровья");
                                heals -= 5;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine(nameCharacter + " решает осмотреться");
                                Console.ReadKey();
                                Console.WriteLine(nameCharacter + " нашл(а) несколько предметов");
                                Console.ReadKey();
                                Console.WriteLine("1) Палка");
                                Console.WriteLine("2) Тупой меч");
                                Console.WriteLine(nameCharacter + ": Что взять?");
                                items = int.Parse(Console.ReadLine());

                                switch (items)
                                {
                                    case 1:
                                        Console.WriteLine(nameCharacter + " взял(а) палку");
                                        damage = 8;
                                        weapon = stick;
                                        luck = true;
                                        Console.WriteLine($"Урон = {damage}");
                                        Console.ReadKey();

                                        break;

                                    case 2:
                                        Console.WriteLine(nameCharacter + " взял(а) меч");
                                        damage = 20;
                                        weapon = sword;
                                        luck = false;
                                        Console.WriteLine($"Урон = {damage}");
                                        Console.ReadKey();

                                        break;
                                }
                                Console.WriteLine(nameCharacter + " решает использовать " + weapon + ", чтобы убрать крапиву и достать ключ");
                                Console.ReadKey();
                                Console.WriteLine(nameCharacter + " использовал(а) ключ, чтобы активировать монумент");
                                Console.ReadKey();
                                Console.Clear();
                            }

                        }
                        else
                        {
                            Console.WriteLine(nameCharacter + " решает осмотреться");
                            Console.ReadKey();
                            Console.WriteLine(nameCharacter + " нашл(а) несколько предметов");
                            Console.ReadKey();
                            Console.WriteLine("1) Палка");
                            Console.WriteLine("2) Тупой меч");
                            Console.WriteLine(nameCharacter + ": Что взять?");
                            items = int.Parse(Console.ReadLine());

                            switch (items)
                            {
                                case 1:
                                    Console.WriteLine(nameCharacter + " взял(а) палку");
                                    damage = 8;
                                    weapon = stick;
                                    luck = true;
                                    Console.WriteLine($"Урон = {damage}");
                                    Console.ReadKey();

                                    break;

                                case 2:
                                    Console.WriteLine(nameCharacter + " взял(а) меч");
                                    damage = 20;
                                    weapon = sword;
                                    luck = false;
                                    Console.WriteLine($"Урон = {damage}");
                                    Console.ReadKey();

                                    break;
                            }
                            Console.WriteLine(nameCharacter + " решает использовать " + weapon + ", чтобы убрать крапиву и достать ключ");
                            Console.ReadKey();
                            Console.WriteLine(nameCharacter + " использовал(а) ключ, чтобы активировать монумент");
                            Console.ReadKey();
                            Console.Clear();

                        }

                    }
                }
                else
                {
                    Console.WriteLine("Немного осмотревшись " + nameCharacter + " замечает, что что-то блестит за монументом в кустах");
                    Console.ReadKey();
                    Console.WriteLine("Осмотреть куст? (да / нет)");
                    decision = Convert.ToString(Console.ReadLine());

                    if (decision.ToLower() == "да")
                    {
                        Console.WriteLine("Осмотрев кус, " + nameCharacter + " подмечаете, что этокрапива");
                        Console.ReadKey();
                        Console.WriteLine("На дне крапивы лежит ключ\n");
                        Console.WriteLine("Взять ключ?({0} получит ожог руки)\n (да / нет)", nameCharacter);
                        decision = Convert.ToString(Console.ReadLine());

                        if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                        {
                            Console.WriteLine(nameCharacter + " взял(а) ключ, но обожгл(а) руку");
                            Console.ReadKey();
                            Console.WriteLine("-5 Здоровья");
                            heals -= 5;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine(nameCharacter + " решает осмотреться");
                            Console.ReadKey();
                            Console.WriteLine(nameCharacter + " нашл(а) несколько предметов");
                            Console.ReadKey();
                            Console.WriteLine("1) Палка");
                            Console.WriteLine("2) Тупой меч");
                            Console.WriteLine(nameCharacter + ": Что взять?");
                            items = int.Parse(Console.ReadLine());

                            switch (items)
                            {
                                case 1:
                                    Console.WriteLine(nameCharacter + " взял(а) палку");
                                    damage = 8;
                                    weapon = stick;
                                    luck = true;
                                    Console.WriteLine($"Урон = {damage}");
                                    Console.ReadKey();

                                    break;

                                case 2:
                                    Console.WriteLine(nameCharacter + " взял(а) меч");
                                    damage = 20;
                                    weapon = sword;
                                    luck = false;
                                    Console.WriteLine($"Урон = {damage}");
                                    Console.ReadKey();

                                    break;
                            }
                            Console.WriteLine(nameCharacter + " решает использовать " + weapon + ", чтобы убрать крапиву и достать ключ");
                            Console.ReadKey();
                            Console.WriteLine(nameCharacter + " использовал(а) ключ, чтобы активировать монумент");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine(nameCharacter + " побродил(а) вокруг, но ничего не найдя решает осмотреть куст");
                        Console.ReadKey();
                        Console.WriteLine("Осмотрев куст " + nameCharacter + " замечает ключ на дне");
                        Console.ReadKey();
                        Console.WriteLine("Взять ключ? ({0} получит ожог руки)\n (да / нет)", nameCharacter);
                        decision = Convert.ToString(Console.ReadLine());

                        if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                        {
                            Console.WriteLine(nameCharacter + " взял(а) ключ, но обожгл(а) руку");
                            Console.ReadKey();
                            Console.WriteLine("-5 Здоровья");
                            heals -= 5;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine(nameCharacter + " решает осмотреться");
                            Console.ReadKey();
                            Console.WriteLine(nameCharacter + " нашл(а) несколько предметов");
                            Console.ReadKey();
                            Console.WriteLine("1) Палка");
                            Console.WriteLine("2) Тупой меч");
                            Console.WriteLine(nameCharacter + ": Что взять?");
                            items = int.Parse(Console.ReadLine());

                            switch (items)
                            {
                                case 1:
                                    Console.WriteLine(nameCharacter + " взял(а) палку");
                                    damage = 8;
                                    weapon = stick;
                                    luck = true;
                                    Console.WriteLine($"Урон = {damage}");
                                    Console.ReadKey();

                                    break;

                                case 2:
                                    Console.WriteLine(nameCharacter + " взял(а) меч");
                                    damage = 20;
                                    weapon = sword;
                                    luck = false;
                                    Console.WriteLine($"Урон = {damage}");
                                    Console.ReadKey();

                                    break;
                            }
                            Console.WriteLine(nameCharacter + " решает использовать " + weapon + ", чтобы убрать крапиву и достать ключ");
                            Console.ReadKey();
                            Console.WriteLine(nameCharacter + " использовал(f) ключ, чтобы активировать монумент");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }

                Console.Clear();

                timer += 1;
                Console.WriteLine("Монумент активирован");
                Console.ReadKey();

                Console.Clear();

                Console.WriteLine(nameCharacter + " подошёл(а) ко второму монументу. Там висела табличка с текстом:\n \nДень спит, ночь глядит, утром умирает, другая ее сменяет\n");

                Console.WriteLine("1 - Свеча");
                Console.WriteLine("2 - Солнце");
                Console.WriteLine("3 - Огонь");
                decision = Convert.ToString(Console.ReadLine());


                if (decision.ToLower() == "свеча")
                {
                    Console.WriteLine("Верно!");
                    mood += 10;
                }
                else
                {

                    int decisionInt = int.Parse(decision);

                    if (decisionInt == 1)
                    {
                        Console.WriteLine("Верно!");
                        mood += 10;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Свеча потухла!");
                        Console.WriteLine("Зажечь свечу снова? (да/нет)");
                        decision = Convert.ToString(Console.ReadLine());

                        if (decision.ToLower() == "да")
                        {
                            if (luck == true)
                            {
                                Console.Clear();
                                Console.WriteLine("Свеча зажглась! Замок открыт!");
                                luck = false;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Не получается зажечь...");
                                Console.ReadKey();

                                Console.Clear();
                                Console.WriteLine(nameCharacter + " попробовал(а) ущё раз");
                                Console.ReadKey();
                            }
                        }
                    }
                }

                timer += 1;
                Console.Clear();

                Console.WriteLine("Монумент активирован");
                Console.ReadKey();

                Console.Clear();

                Console.WriteLine(nameCharacter + " подошёл к третьему монументу около которого был проход");
                Console.ReadKey();
                Console.WriteLine("За монументом есть табличка с надписью\n");
                Console.WriteLine("На табличке написано:\n");
                Console.WriteLine("То что ты ищешь находиться в конце этого тунеля");
                Console.ReadKey();

                Console.Clear();

                Console.WriteLine(nameCharacter + " проходить в таинственный проход");
                Console.ReadKey();

                Console.WriteLine("войдя в проход " + nameCharacter + " видит спуск со странными блестящими обломками");
                Console.ReadKey();
                Console.WriteLine("собрать обломки? (да / нет)");
                decision = Convert.ToString(Console.ReadLine());
                int fragmentsOfTheKey = 0;
                int fragmrntsNumber = 0;
                Random random = new Random();

                if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                {
                    Console.Clear();

                    for(fragmentsOfTheKey = 0; fragmentsOfTheKey < 10;)
                    {

                        int randomChange = random.Next(0, 5);
                        int randomItems = random.Next(0, 10);

                        Console.Clear();

                        Console.WriteLine(nameCharacter + " продолжает путь");

                        switch (randomChange)
                        {
                            case 0:
                            case 1:
                                Console.WriteLine(nameCharacter + " ничего не нашёл");
                                break;
                            case 2:
                            case 3:
                            case 4:
                                Console.WriteLine(nameCharacter + " нашёл обломок");
                                Console.WriteLine($"+1 обломок");
                                fragmentsOfTheKey++;
                                Console.WriteLine($"всего {fragmentsOfTheKey} обломок");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            case 5:
                                Console.WriteLine(nameCharacter + " нашел рюкзак");
                                Console.WriteLine("открыть рюкзак? (да / нет)");
                                decision = Convert.ToString(Console.ReadLine());

                                if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                                {
                                    switch (randomItems)
                                    {
                                        case 0:
                                        case 1:
                                        case 2:
                                            Console.WriteLine("рюкзак пустой");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;

                                        case 3:
                                        case 4:
                                        case 5:
                                        case 6:
                                        case 7:
                                        case 8:
                                            Console.WriteLine(nameCharacter + " нашёл слабую аптечку(+5 здоровья) ");
                                            Console.WriteLine("взять? (да / нет)");
                                            decision = Console.ReadLine();

                                            if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                                            {
                                                Console.WriteLine(nameCharacter + " положил малое зелье здоровья в рюкзак");
                                                Console.WriteLine("+ 1 малое зелье здоровья");
                                                littleHealsInInventory += 1;
                                            }
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;

                                        case 9:
                                            Console.WriteLine(nameCharacter + " нашёл что-то особенное");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine(nameCharacter + " оставил рюкзак");
                                    Console.ReadKey();
                                    Console.Clear();
                                }

                                break;
                        }

                        

                        if(fragmentsOfTheKey == 3 && fragmrntsNumber == 0)
                        {
                            Console.WriteLine(nameCharacter + " заметил(а), что на обломках есть узоры");
                            fragmrntsNumber++;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (fragmentsOfTheKey == 7 && fragmrntsNumber == 1)
                        {
                            Console.WriteLine(nameCharacter + " заметил(а), что если сложить обломки, то они образуют единый рисунок");
                            fragmrntsNumber++;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (fragmentsOfTheKey == 9 && fragmrntsNumber == 2)
                        {
                            Console.WriteLine(nameCharacter + " заметил(а), что обломки образовали целостный рисунок \n");
                            fragmrntsNumber++;
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    Console.WriteLine( "собрал все обломки");
                    Console.ReadKey();
                }

                Console.WriteLine(nameCharacter + " дошёл до конца тунеля видит табличку");

                if(fragmentsOfTheKey > 9)
                {
                    Console.WriteLine("У тебя уже есть ключ, который активирует последний монумент");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Последний артефакт был разделён на 10 частей и разбросан по всему проходу");
                    Console.ReadKey();
                }

                string enemy = "Гоблин";
                int healsEnemy = 100;
                int damageEneme = 2;

                Console.WriteLine("возвращаясь обратно " + nameCharacter + $" натыкается на {enemy}");
                Console.ReadKey();

                int changeInFight = 0;
                int changeMoveInFight = 0;


                Console.Clear();
                Console.WriteLine("Бой начался!");
                Console.ReadKey();

                
                while(healsEnemy > 0 && changeInFight !=4 && heals > 0)
                {
                    Console.Clear();
                    changeMoveInFight = 0;

                    while(changeMoveInFight == 0)
                    {
                        Console.Clear();

                        Console.WriteLine("Вариация действий:");
                        Console.WriteLine("1)Ударить рукой");
                        Console.WriteLine("2)Ударить " + weapon);
                        Console.WriteLine("3)Просто стоять и бояться");
                        Console.WriteLine("4)открыть инвентарь");
                        Console.WriteLine("Выбор действия:");

                        if(int.TryParse(Console.ReadLine(), out changeInFight))
                        {
                            switch(changeInFight)
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
                                    Console.WriteLine("Вы наносите удар по гоблину " + weapon);
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
                                    Console.WriteLine(nameCharacter + " открыл инвентарь");
                                    Console.ReadKey();

                                    bool inventory = true;

                                    while(inventory)
                                    {
                                        Console.Clear();

                                        Console.WriteLine("=== ИНВЕНТАРЬ ===");

                                        if (littleHealsInInventory > 0)
                                        {
                                            Console.WriteLine($"1) {littleHealsInInventory} малое зелье здоровья");
                                        }
                                        else
                                        {
                                            Console.WriteLine("инвентарь пуст");
                                            Console.ReadKey();
                                        }

                                        Console.WriteLine("0) Вернуться");
                                        Console.WriteLine("\nЧто использовать? ");
                                        items = int.Parse(Console.ReadLine());

                                        switch (items)
                                        {
                                            case 0:
                                                inventory = false;
                                                changeMoveInFight = 1;
                                                break;

                                            case 1:
                                                Console.WriteLine(nameCharacter + " использовал моле зелье лечения и восстановил здоровье");
                                                heals += littleHealsPosion;
                                                littleHealsInInventory -= 1;
                                                Console.ReadKey();
                                                inventory = false;
                                                changeMoveInFight = 0;
                                                break;

                                            default:
                                                Console.WriteLine("Неверный выбор");
                                                break;
                                        }
                                    }
                                    
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
                            Console.Clear();
                            Console.WriteLine($"\n{enemy} бьёт вас");
                            heals -= damageEneme;
                            Console.WriteLine($"\n{enemy} наносит вам {damageEneme} урона");
                            Console.ReadKey();
                        }

                    

                    Console.Clear();

                    Console.WriteLine("=== Характеристики ===");

                    Console.Clear();
                    Console.WriteLine("Характеристики " + nameCharacter);
                    Console.WriteLine("Здоровье: " + heals);

                    Console.WriteLine("\n=== Характеристики " + enemy + " ===");
                    Console.WriteLine("Здоровье: " + healsEnemy);
                    Console.ReadKey();

                }
                
                if(healsEnemy <= 0)
                {
                    Console.Clear();
                    Console.WriteLine(nameCharacter + " победил");
                    Console.ReadKey();
                }
                else if (heals <= 0)
                {
                    Console.Clear();
                    Console.WriteLine(nameCharacter + " героически погиб");
                    Console.ReadKey();
                }
                else if (healsEnemy <= 0)
                {
                    Console.Clear();
                    Console.WriteLine(nameCharacter + " сбежал с поля боя, но остался жив");
                    Console.ReadKey();
                }

                Console.Clear();

                Console.WriteLine("Бой окончен");
                Console.ReadKey();

                int NumberOfArtifacts = 0;

                if (heals >= 1)
                {
                    Console.Clear();

                    Console.WriteLine("Активировав все монументы " + nameCharacter + " слышит грохочещий звук");
                    Console.ReadKey();
                    Console.WriteLine("За монументом по середине появляется проход");
                    Console.ReadKey();

                    Console.Clear();

                    Console.WriteLine("Войдя в таинственный проход " + nameCharacter + " видит дверь");
                    Console.ReadKey();
                    Console.WriteLine("На двери написано");
                    Console.WriteLine("Кажды вся суда входящий, должен быть чист сердцем и душой");
                    Console.ReadKey();

                    Console.Clear();

                    Console.WriteLine(nameCharacter + " проходить в Загадочный проход\n");

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

                    Console.WriteLine("\n" + nameCharacter + ": Что мне взять?");
                    artifact = int.Parse(Console.ReadLine());

                    Console.Clear();



                    switch (artifact)
                    {
                        case 1:
                            Console.WriteLine(nameCharacter + " берёт Шляпа Колдуна");
                            heals -= 40;
                            mood += 30;
                            luck = false;
                            holeInBackpack = false;

                            Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                            Console.ReadKey();
                            NumberOfArtifacts += 1;
                            break;
                        case 2:
                            Console.WriteLine(nameCharacter + " берёт Кубок Бессмертия");
                            heals = 150;
                            mood -= 20;
                            luck = true;

                            Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                            Console.ReadKey();
                            NumberOfArtifacts += 1;
                            break;
                        case 3:
                            Console.WriteLine(nameCharacter + " берёт Сердце Феникса");
                            heals += 10;
                            mood += 25;
                            luck = true;
                            holeInBackpack = true;

                            Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                            Console.ReadKey();
                            NumberOfArtifacts += 1;
                            break;
                        case 4:
                            Console.WriteLine(nameCharacter + " берёт Плащ Теней");
                            heals -= 10;
                            mood += 15;
                            luck = true;

                            Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                            Console.ReadKey();
                            NumberOfArtifacts += 1;
                            break;
                        case 5:
                            Console.WriteLine(nameCharacter + " берёт Слеза Королевы");
                            heals -= 40;
                            mood = 100;
                            luck = false;
                            holeInBackpack = true;

                            Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                            Console.ReadKey();
                            NumberOfArtifacts += 1;
                            break;
                        case 6:
                            Console.WriteLine(nameCharacter + " берёт Посох Студента");
                            heals -= 20;
                            mood += 35;
                            luck = false;

                            Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                            Console.ReadKey();
                            NumberOfArtifacts += 1;
                            break;
                        case 7:
                            Console.WriteLine(nameCharacter + " берёт Коготь Дракона");
                            heals += 30;
                            mood += 10;
                            luck = true;
                            holeInBackpack = true;

                            Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                            Console.ReadKey();
                            NumberOfArtifacts += 1;
                            break;
                        case 8:
                            Console.WriteLine(nameCharacter + " берёт Зеркало Прошлого");
                            heals -= 15;
                            mood -= 10;
                            luck = true;

                            Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                            Console.ReadKey();
                            NumberOfArtifacts += 1;
                            break;
                        case 9:
                            Console.WriteLine(nameCharacter + " берёт Сапоги Странника");
                            heals += 20;
                            mood -= 20;
                            luck = true;
                            holeInBackpack = true;

                            Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                            Console.ReadKey();
                            NumberOfArtifacts += 1;
                            break;
                        case 10:
                            Console.WriteLine(nameCharacter + " решает ничего не брать");

                            Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                            Console.ReadKey();
                            break;
                    }

                    if (NumberOfArtifacts >= 1)
                    {
                        Console.WriteLine(nameCharacter + " хочет забрать всё. \nЗабрать всё? (да / нет)");
                        decision = Convert.ToString(Console.ReadLine());

                        if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                        {
                            Console.Clear();

                            Console.WriteLine(nameCharacter + " берёт все сокровища из сокровещницы, но выйдя из грабницы " + nameCharacter + " чуствует боль в груди, падает на землю и хватается за грудь");
                            Console.ReadKey();
                            Console.WriteLine("\nСпустя несколь лет, новые искатели находят тело неизвесного человека");
                            Console.ReadKey();
                        }
                    }

                }
            }
            else
            {
                Console.WriteLine(nameCharacter + ": Думаю не стоит");
                Console.ReadKey();
            }

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Конец игры!");
            Console.ReadKey();

        }
    }
}