using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle.Levels.Towers
{
    internal class FirstTower
    {
        public static void TowerOne(List<Weapon> weapons,string decision, ref int mood, string nameCharacter, ref bool luck, ref int damage, ref string weapon, ref int heals, ref int timer,ref int items, ref string stick, ref string sword)
        {

            

            Console.Clear();

            Console.WriteLine($"{nameCharacter} подошёл(шла) к монументу. \nТам было углубление для ключа ");
            Console.ReadKey();
            Console.WriteLine("Попробовать свой ключ от дома? (да / нет)");
            decision = Convert.ToString(Console.ReadLine());

            if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
            {
                Console.Clear();


                Console.WriteLine($"{nameCharacter} достает маленький ржавый ключ и пытается поставить его\n");
                Console.ReadKey();
                Console.WriteLine("*глухой звук*\n");
                Console.ReadKey();
                Console.WriteLine("Ключ недостаточно мудр...\n");
                Console.WriteLine("Попробовать ещё? (да / нет)");
                decision = Convert.ToString(Console.ReadLine());

                Console.Clear();

                if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                {
                    Console.WriteLine($"{nameCharacter} попробовал(а) с силой поставить ключ, но ничего не получилось\n");
                    Console.ReadKey();
                    Console.WriteLine("Попробовать ещё? (да / нет) ");
                    decision = Convert.ToString(Console.ReadLine());

                    Console.Write(decision);

                    if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                    {
                        Console.WriteLine($"{nameCharacter} попробовал(а) с силой поставить ключ \nКлюч встал,но {nameCharacter} повредил(а) руку");
                        Console.WriteLine($"Здоровье и настроение {nameCharacter} снизилось");
                        Console.ReadKey();

                        heals -= 10;
                        mood -= 25;

                        Console.WriteLine($"Характеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood}\n");
                        Console.ReadKey();
                        timer += 1;
                    }
                    else
                    {
                        Console.WriteLine("Немного осмотревшись {nameCharacter} замечает, что что-то блестит за монументом в кустах\n");
                        Console.ReadKey();
                        Console.WriteLine("Осмотреть куст? (да / нет)");
                        decision = Convert.ToString(Console.ReadLine());

                        if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                        {
                            Console.WriteLine($"Осмотрев кус, {nameCharacter} подмечает, что это крапива\n");
                            Console.ReadKey();
                            Console.WriteLine("На дне крапивы лежит ключ\n");
                            Console.WriteLine($"Взять ключ?({0} получит ожог руки)\n (да / нет), {nameCharacter}");
                            decision = Convert.ToString(Console.ReadLine());

                            if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                            {
                                Console.WriteLine($"{nameCharacter} взял(а) ключ, но получил(а) ожог руки");
                                Console.ReadKey();
                                Console.WriteLine("-5 Здоровья");
                                heals -= 5;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine($"{nameCharacter} решает осмотреться");
                                Console.ReadKey();
                                Console.WriteLine($"{nameCharacter} нашёл(шла) несколько предметов");
                                Console.ReadKey();
                                Console.WriteLine("1) Палка");
                                Console.WriteLine("2) Тупой меч");
                                Console.WriteLine($"{nameCharacter}: Что взять?");
                                items = int.Parse(Console.ReadLine());

                                switch (items)
                                {
                                    case 1:
                                        Console.WriteLine($"{nameCharacter} взял(а) палку");
                                        damage = weapons[0].Damage;
                                        weapon = weapons[0].Name;
                                        luck = true;
                                        Console.WriteLine($"Урон = {damage}");
                                        Console.ReadKey();

                                        break;

                                    case 2:
                                        Console.WriteLine($"{nameCharacter} взял(а) меч");
                                        damage = weapons[1].Damage;
                                        weapon = weapons[1].Name;
                                        luck = false;
                                        Console.WriteLine($"Урон = {damage}");
                                        Console.ReadKey();

                                        break;
                                }
                                Console.WriteLine($"{nameCharacter} решает использовать {weapon}, чтобы убрать крапиву и достать ключ");
                                Console.ReadKey();
                                Console.WriteLine($"{nameCharacter} использовал(а) ключ, чтобы активировать монумент");
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{nameCharacter} решает осмотреться");
                            Console.ReadKey();
                            Console.WriteLine($"{nameCharacter} нашёл(шла) несколько предметов");
                            Console.ReadKey();
                            Console.WriteLine("1) Палка");
                            Console.WriteLine("2) Тупой меч");
                            Console.WriteLine($"{nameCharacter}: Что взять?");
                            items = int.Parse(Console.ReadLine());

                            switch (items)
                            {
                                case 1:
                                    Console.WriteLine($"{nameCharacter} взял(а) палку");
                                    damage = weapons[0].Damage;
                                    weapon = weapons[0].Name;
                                    luck = true;
                                    Console.WriteLine($"Урон = {damage}");
                                    Console.ReadKey();

                                    break;

                                case 2:
                                    Console.WriteLine($"{nameCharacter} взял(а) меч");
                                    damage = weapons[1].Damage;
                                    weapon = weapons[1].Name;
                                    luck = false;
                                    Console.WriteLine($"Урон = {damage}");
                                    Console.ReadKey();

                                    break;
                            }
                            Console.WriteLine($"{nameCharacter} решает использовать {weapon}, чтобы убрать крапиву и достать ключ");
                            Console.ReadKey();
                            Console.WriteLine($"{nameCharacter} использовал(а) ключ, чтобы активировать монумент");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Немного осмотревшись {nameCharacter} замечает, что что-то блестит за монументом в кустах");
                    Console.ReadKey();
                    Console.WriteLine("Осмотреть куст? (да / нет)");
                    decision = Convert.ToString(Console.ReadLine());

                    if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                    {
                        Console.WriteLine($"Осмотрев кус, {nameCharacter} подмечает, что это крапива");
                        Console.ReadKey();
                        Console.WriteLine("На дне крапивы лежит ключ\n");
                        Console.WriteLine($"Взять ключ?(получит ожог руки)\n (да / нет)");
                        decision = Convert.ToString(Console.ReadLine());

                        if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                        {
                            Console.WriteLine($"{nameCharacter} взял(а) ключ, но обожгл(а) руку");
                            Console.ReadKey();
                            Console.WriteLine("-5 Здоровья");
                            heals -= 5;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine($"{nameCharacter} решает осмотреться");
                            Console.ReadKey();
                            Console.WriteLine($"{nameCharacter} нашл(а) несколько предметов");
                            Console.ReadKey();
                            Console.WriteLine("1) Палка");
                            Console.WriteLine("2) Тупой меч");
                            Console.WriteLine($"{nameCharacter}: Что взять?");
                            items = int.Parse(Console.ReadLine());

                            switch (items)
                            {
                                case 1:
                                    Console.WriteLine($"{nameCharacter} взял(а) палку");
                                    damage = weapons[0].Damage;
                                    weapon = weapons[0].Name;
                                    luck = true;
                                    Console.WriteLine($"Урон = {damage}");
                                    Console.ReadKey();

                                    break;

                                case 2:
                                    Console.WriteLine($"{nameCharacter} взял(а) меч");
                                    damage = weapons[1].Damage;
                                    weapon = weapons[1].Name;
                                    luck = false;
                                    Console.WriteLine($"Урон = {damage}");
                                    Console.ReadKey();

                                    break;
                            }
                            Console.WriteLine($"{nameCharacter} решает использовать {weapon}, чтобы убрать крапиву и достать ключ");
                            Console.ReadKey();
                            Console.WriteLine($"{nameCharacter} использовал(а) ключ, чтобы активировать монумент");
                            Console.ReadKey();
                            Console.Clear();
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{nameCharacter} решает осмотреться");
                        Console.ReadKey();
                        Console.WriteLine($"{nameCharacter} нашл(а) несколько предметов");
                        Console.ReadKey();
                        Console.WriteLine("1) Палка");
                        Console.WriteLine("2) Тупой меч");
                        Console.WriteLine($"{nameCharacter}: Что взять?");
                        items = int.Parse(Console.ReadLine());

                        switch (items)
                        {
                            case 1:
                                Console.WriteLine($"{nameCharacter} взял(а) палку");
                                damage = weapons[0].Damage;
                                weapon = weapons[0].Name;
                                luck = true;
                                Console.WriteLine($"Урон = {damage}");
                                Console.ReadKey();

                                break;

                            case 2:
                                Console.WriteLine($"{nameCharacter} взял(а) меч");
                                damage = weapons[1].Damage;
                                weapon = weapons[1].Name;
                                luck = false;
                                Console.WriteLine($"Урон = {damage}");
                                Console.ReadKey();

                                break;
                        }
                        Console.WriteLine($"{nameCharacter} решает использовать {weapon}, чтобы убрать крапиву и достать ключ");
                        Console.ReadKey();
                        Console.WriteLine($"{nameCharacter} использовал(а) ключ, чтобы активировать монумент");
                        Console.ReadKey();
                        Console.Clear();

                    }

                }
            }
            else
            {
                Console.WriteLine($"Немного осмотревшись {nameCharacter} замечает, что что-то блестит за монументом в кустах");
                Console.ReadKey();
                Console.WriteLine("Осмотреть куст? (да / нет)");
                decision = Convert.ToString(Console.ReadLine());

                if (decision.ToLower() == "да")
                {
                    Console.WriteLine($"Осмотрев кус, {nameCharacter} подмечаете, что этокрапива");
                    Console.ReadKey();
                    Console.WriteLine("На дне крапивы лежит ключ\n");
                    Console.WriteLine("Взять ключ?({0} получит ожог руки)\n (да / нет)");
                    decision = Convert.ToString(Console.ReadLine());

                    if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                    {
                        Console.WriteLine($"{nameCharacter} взял(а) ключ, но обожгл(а) руку");
                        Console.ReadKey();
                        Console.WriteLine("-5 Здоровья");
                        heals -= 5;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"{nameCharacter} решает осмотреться");
                        Console.ReadKey();
                        Console.WriteLine($"{nameCharacter} нашл(а) несколько предметов");
                        Console.ReadKey();
                        Console.WriteLine("1) Палка");
                        Console.WriteLine("2) Тупой меч");
                        Console.WriteLine($"{nameCharacter}: Что взять?");
                        items = int.Parse(Console.ReadLine());

                        switch (items)
                        {
                            case 1:
                                Console.WriteLine($"{nameCharacter} взял(а) палку");
                                damage = weapons[0].Damage;
                                weapon = weapons[0].Name;
                                luck = true;
                                Console.WriteLine($"Урон = {damage}");
                                Console.ReadKey();

                                break;

                            case 2:
                                Console.WriteLine($"{nameCharacter} взял(а) меч");
                                damage = weapons[1].Damage;
                                weapon = weapons[1].Name;
                                luck = false;
                                Console.WriteLine($"Урон = {damage}");
                                Console.ReadKey();

                                break;
                        }
                        Console.WriteLine($"{nameCharacter} решает использовать {weapon}, чтобы убрать крапиву и достать ключ");
                        Console.ReadKey();
                        Console.WriteLine($"{nameCharacter} использовал(а) ключ, чтобы активировать монумент");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine($"{nameCharacter} побродил(а) вокруг, но ничего не найдя решает осмотреть куст");
                    Console.ReadKey();
                    Console.WriteLine($"Осмотрев куст {nameCharacter} замечает ключ на дне");
                    Console.ReadKey();
                    Console.WriteLine("Взять ключ? ({0} получит ожог руки)\n (да / нет)");
                    decision = Convert.ToString(Console.ReadLine());

                    if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                    {
                        Console.WriteLine($"{nameCharacter} взял(а) ключ, но обожгл(а) руку");
                        Console.ReadKey();
                        Console.WriteLine("-5 Здоровья");
                        heals -= 5;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"{nameCharacter} решает осмотреться");
                        Console.ReadKey();
                        Console.WriteLine($"{nameCharacter} нашл(а) несколько предметов");
                        Console.ReadKey();
                        Console.WriteLine("1) Палка");
                        Console.WriteLine("2) Тупой меч");
                        Console.WriteLine(nameCharacter + ": Что взять?");
                        items = int.Parse(Console.ReadLine());

                        switch (items)
                        {
                            case 1:
                                Console.WriteLine($"{nameCharacter} взял(а) палку");
                                damage = weapons[0].Damage;
                                weapon = weapons[0].Name;
                                luck = true;
                                Console.WriteLine($"Урон = {damage}");
                                Console.ReadKey();

                                break;

                            case 2:
                                Console.WriteLine($"{nameCharacter} взял(а) меч");
                                damage = weapons[1].Damage;
                                weapon = weapons[1].Name;
                                luck = false;
                                Console.WriteLine($"Урон = {damage}");
                                Console.ReadKey();

                                break;
                        }
                        Console.WriteLine($"{nameCharacter} решает использовать {weapon}, чтобы убрать крапиву и достать ключ");
                        Console.ReadKey();
                        Console.WriteLine($"{nameCharacter} использовал(а) ключ, чтобы активировать монумент");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }
    }
}
