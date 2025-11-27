using Alias_and_Castle.Levels.Lake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Alias_and_Castle
{
    internal class FallingToTheVeryBottom
    {
        public static void Liana(string nameCharacter, string decision, Random random, int heals, int damage, List<MedKit> medKits,
            List<Weapon> weapons, List<LittleThings> littleThings, List<PlayerInventory> playerInventories, string weapon)
        {
            Console.Clear();


            Console.WriteLine($"Возвращаясь к выходу {nameCharacter} насступает на камень и пол проваливается");
            Console.ReadKey();
            Console.WriteLine($"{nameCharacter} успел(а) схватиться за лиану");
            Console.WriteLine($"{nameCharacter}: куда полсти? \n1)Вверх \n2)Вниз");
            decision = Console.ReadLine();

            switch (decision)
            {
                case "1":
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Clear();

                        Console.WriteLine($"{nameCharacter} ползёт вверх");

                        MoveOnLiane.MovingUpTheCreeper(nameCharacter, decision, random, heals, damage, medKits,
                            weapons, littleThings);

                        Console.WriteLine($"{nameCharacter} оступился(ась) и упал(а) в озело");
                    }
                    break;
                case "2":
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Clear();

                        Console.WriteLine($"{nameCharacter} ползёт вниз");

                        MoveOnLiane.MovingUpTheCreeper( nameCharacter, decision, random, heals, damage, medKits,
                            weapons, littleThings);

                        Console.WriteLine($"{nameCharacter} оступился(ась) и упал(а) в озело");
                    }
                    break;
            }
            Console.ReadKey();

            Console.WriteLine($"выплыв и осмотревшись, {nameCharacter} видет перед собой озеро и лавку за которой стоит старый человек");

            Console.ReadKey();


        }

    }
}
