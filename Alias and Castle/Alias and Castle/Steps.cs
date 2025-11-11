using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle
{
    internal class Steps
    {
        public static void StairsWhitFragmentsOfTheKey(string decision, Random random, ref int fragmentsOfTheKey, ref string nameCharacter, ref int littleHealsInInventory, ref int fragmrntsNumber)
        {
            if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
            {
                Console.Clear();

                for (fragmentsOfTheKey = 0; fragmentsOfTheKey < 10;)
                {
                    int randomChange = random.Next(0, 100);
                    int randomItems = random.Next(0, 10);

                    Console.Clear();
                    Console.WriteLine($"{nameCharacter} продолжает путь");

                    if (randomChange < 40)
                    {
                        Console.WriteLine($"{nameCharacter} ничего не нашёл");
                    }
                    else if (randomChange < 75)
                    {
                        Console.WriteLine($"{nameCharacter} нашёл обломок");
                        Console.WriteLine($"+1 обломок");
                        fragmentsOfTheKey++;
                        Console.WriteLine($"всего {fragmentsOfTheKey} обломок");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (randomChange < 90)
                    {
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
                                    Console.WriteLine($"{nameCharacter} нашёл слабую аптечку(+5 здоровья) ");
                                    Console.WriteLine("взять? (да / нет)");
                                    decision = Console.ReadLine();

                                    if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                                    {
                                        Console.WriteLine($"{nameCharacter} положил малое зелье здоровья в рюкзак");
                                        Console.WriteLine("+ 1 малое зелье здоровья");
                                        littleHealsInInventory += 1;
                                    }
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case 8:
                                case 9:
                                    Console.WriteLine($"{nameCharacter} нашёл что-то особенное");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{nameCharacter} оставил рюкзак");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{nameCharacter} нашёл что-то необычное...");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    if (fragmentsOfTheKey == 3 && fragmrntsNumber == 0)
                    {
                        Console.WriteLine($"{nameCharacter} заметил(а), что на обломках есть узоры");
                        fragmrntsNumber++;
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (fragmentsOfTheKey == 7 && fragmrntsNumber == 1)
                    {
                        Console.WriteLine($"{nameCharacter} заметил(а), что если сложить обломки, то они образуют единый рисунок");
                        fragmrntsNumber++;
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (fragmentsOfTheKey == 9 && fragmrntsNumber == 2)
                    {
                        Console.WriteLine($"{nameCharacter} заметил(а), что обломки образовали целостный рисунок \n");
                        fragmrntsNumber++;
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                Console.WriteLine($"{nameCharacter} собрал(а) все обломки");
                Console.ReadKey();
            }
        }
    }
}