using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle.Levels.Towers
{
    internal class RoomWhisArtifacts
    {
        public static void ArtefactsRoom(string nameCharacter, int heals, bool luck, int artifact, int mood, bool holeInBackpack, int NumberOfArtifacts, string decision)
        {
                
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

                Console.WriteLine($"\n{nameCharacter}: Что мне взять?");
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
                        NumberOfArtifacts =+ 1;
                        break;
                    case 2:
                        Console.WriteLine($"{nameCharacter} берёт Кубок Бессмертия");
                        heals = 150;
                        mood -= 20;
                        luck = true;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts = +1;
                        break;
                    case 3:
                        Console.WriteLine($"{nameCharacter} берёт Сердце Феникса");
                        heals += 10;
                        mood += 25;
                        luck = true;
                        holeInBackpack = true;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts = +1;
                        break;
                    case 4:
                        Console.WriteLine($"{nameCharacter} берёт Плащ Теней");
                        heals -= 10;
                        mood += 15;
                        luck = true;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts = +1;
                        break;
                    case 5:
                        Console.WriteLine($"{nameCharacter} берёт Слеза Королевы");
                        heals -= 40;
                        mood = 100;
                        luck = false;
                        holeInBackpack = true;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts = +1;
                        break;
                    case 6:
                        Console.WriteLine($"{nameCharacter} берёт Посох Студента");
                        heals -= 20;
                        mood += 35;
                        luck = false;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts = +1;
                        break;
                    case 7:
                        Console.WriteLine($"{nameCharacter} берёт Коготь Дракона");
                        heals += 30;
                        mood += 10;
                        luck = true;
                        holeInBackpack = true;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts = +1;
                        break;
                    case 8:
                        Console.WriteLine($"{nameCharacter} берёт Зеркало Прошлого");
                        heals -= 15;
                        mood -= 10;
                        luck = true;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts = +1;
                        break;
                    case 9:
                        Console.WriteLine($"{nameCharacter} берёт Сапоги Странника");
                        heals += 20;
                        mood -= 20;
                        luck = true;
                        holeInBackpack = true;

                        Console.WriteLine($"\nХарактеристики {nameCharacter}: \nЗдоровье: {heals} \nНастроение: {mood},\nудача: {luck}");
                        Console.ReadKey();
                        NumberOfArtifacts = +1;
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
