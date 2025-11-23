using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle
{
    internal class BackpackRandomItems
    {
        public static void backPackRandomItem(List<MedKit> medKit, List<LittleThings> littleThings, string nameCharacter, Random random, string decision)
        {
            int randomItems = random.Next(0, 10);
            int randomMoney = random.Next(0, 10);

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
                    Console.WriteLine($"{nameCharacter} нашёл {random} монеты");
                    littleThings[0].Quantity += randomMoney;
                    break;
                case 6:
                case 7:
                    Console.WriteLine($"{nameCharacter} нашё {medKit[0].Size}(+5 здоровья) ");
                    Console.WriteLine("взять? (да / нет)");
                    decision = Console.ReadLine();

                    if (decision.ToLower() == "да" || decision.ToLower() == "д" || decision.ToLower() == "а")
                    {
                        Console.WriteLine($"{nameCharacter} положил {medKit[0].Size} в рюкзак");
                        Console.WriteLine("+ 1 малое зелье здоровья");
                        medKit[0].Quantity += 1;
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
    }
}
