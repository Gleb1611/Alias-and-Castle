using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle.Levels.Lake
{
    internal class LakeWhithCoins
    {
        public static void lakeAndShop(string nameCharacter, List<MedKit> medKits, List<Weapon> weapons,
            List<LittleThings> littleThings, List<PlayerInventory> playerInventories, int damage, int heals, string weapon, string decision, Random random)
        {
            bool beingNearALake = false;
            bool oldManQustion = true;
            bool qustionNumberFour = false;

            while (!beingNearALake)
            {

                Console.WriteLine($"{nameCharacter} подошёл к старому человеку");


                while (oldManQustion)
                {
                    Console.WriteLine("Вариант взаимодействия:");
                    Console.WriteLine("1)Кто вы такой?");
                    Console.WriteLine("2)Где я?");
                    Console.WriteLine("3)Что тут вообще есть?");

                    if (qustionNumberFour)
                    {
                        Console.WriteLine("4)Как от сюда выбраться?");
                    }

                    Console.WriteLine("\nCпросить: ");
                    decision = Console.ReadLine();

                    switch (decision)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Старик ответил:");
                            Console.WriteLine("Я проводник для людей, которые не могут найти выход. А ещё я владелец этой лавки");
                            Console.ReadKey();

                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Старик ответил:");
                            Console.WriteLine("Если кратко, то ты на самом дне");
                            Console.ReadKey();
                            qustionNumberFour = true;

                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("Старик ответил:");
                            Console.WriteLine("Здесь есть озеро в котором ты можешь вылоаить что-нибудь цунное и продать мне. " +
                                "\nМоя лавка в которой мы можем поторговаться. " +
                                "\nИ наконец костёр, около которого ты можешь передохнуть");
                            Console.ReadKey();

                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Старик ответил:");
                            Console.WriteLine("Если вы не умеете летать или не владеете магией телепортации, то только купить у меня кристал телепортации");
                            Console.ReadKey();
                            beingNearALake = true;
                            oldManQustion = false;
                            break;
                    }
                }

            }

            while (beingNearALake)
            {
                Console.Clear();

                Console.WriteLine("1) Костёр");
                Console.WriteLine("2) Озеро");
                Console.WriteLine("3) Лавка старика");

                decision = Console.ReadLine();

                switch (decision)
                {
                    case "1":

                        break;
                    case "2":
                        Console.Clear();

                        LakeCoins.Lake(nameCharacter, medKits, weapons,
                            littleThings, playerInventories, damage, heals,weapon, decision, random);
                        break;
                    case "3":

                        break;
                }
            }
        }
    }
}
