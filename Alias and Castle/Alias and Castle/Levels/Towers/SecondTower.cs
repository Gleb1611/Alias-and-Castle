using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle.Levels.Towers
{
    internal class SecondTower
    {
        public static void TowerTwo(string decision, ref int mood, ref string nameCharacter, ref bool luck)
        {
            Console.WriteLine($"{nameCharacter} подошёл(а) к монументу. Там висела табличка с текстом:\n \nДень спит, ночь глядит, утром умирает, другая ее сменяет\n");

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
        }
    }
}
