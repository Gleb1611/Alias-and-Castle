using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle
{
    internal class MoveOnLiane
    {
        public static void MovingUpTheCreeper(string nameCharacter, string decision, Random random, int heals, int damage, List<MedKit> medKits,
            List<Weapon> weapons, List<LittleThings> littleThings)
        {
            Console.Clear();
            Console.WriteLine($"{nameCharacter} подлзёт дальше");
            Console.ReadKey();

            int randomEvent = random.Next(0, 2);

            switch (randomEvent)
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

                    BackpackRandomItems.backPackRandomItem(medKits, littleThings, nameCharacter, random, decision);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine($"{nameCharacter} укололся шипом от лианы \n -5 здоровья");
                    heals -= 5;
                    break;
            }
        }
    }
}
