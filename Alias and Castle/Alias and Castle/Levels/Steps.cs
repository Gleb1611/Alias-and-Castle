using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle.Levels
{
    internal class Steps
    {
        public static void StairsWhitFragmentsOfTheKey(List<MedKit> medKit, List<LittleThings> littleThings, string decision, Random random, ref int fragmentsOfTheKey, ref string nameCharacter, ref int littleHealsInInventory, ref int fragmrntsNumber)
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
                            BackpackRandomItems.backPackRandomItem(medKit,littleThings, nameCharacter, random, decision);
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