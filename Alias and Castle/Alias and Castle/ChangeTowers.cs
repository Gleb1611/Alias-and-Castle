using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Alias_and_Castle
{
    internal class ChangeTowers
    {
        public static void MainChange(int towerTimerOne, int towerTimerTwo, int towerTimerThree, int NumberOfArtifacts, 
            string decision, int damage, string weapon, int heals, int timer, int items, string stick, string sword, bool luck, string nameCharacter, int mood, 
            int littleHealsInInventory, int damageArm, int littleHealsPosion, bool holeInBackpack, int artifact)
        {
            while (towerTimerOne == 0 || towerTimerTwo == 0 || towerTimerThree == 0 || NumberOfArtifacts == 0)
            {
                Console.Clear();

                Console.WriteLine("Куда идти?");
                Console.WriteLine("1) Монумент с лево");
                Console.WriteLine("2) Монумент по середине");
                Console.WriteLine("3) Монумент с право");
                if (towerTimerOne == 1 && towerTimerTwo == 1 && towerTimerThree == 1)
                {
                    Console.WriteLine("4) Таинственный проход");
                }
                decision = Console.ReadLine();

                switch (decision)
                {
                    case "1":
                        if (towerTimerOne == 0)
                        {

                            Console.Clear();

                            Console.WriteLine("=== Монумент с лево ===");
                            Console.WriteLine("Загадочный столб с небольшим углублением под ключ");
                            Console.WriteLine("Подойти?");
                            Console.WriteLine("1)Попробовать активировать монумент\n" +
                                "0)Вернуться");
                            decision = Console.ReadLine();

                            switch (decision)
                            {
                                case "1":

                                    Console.Clear();

                                    towerTimerOne = 1;
                                    FirstTower.TowerOne(decision, ref mood, nameCharacter, ref luck, ref damage, ref weapon, ref heals, ref timer, ref items, ref stick, ref sword);
                                    break;

                                default:

                                    Console.Clear();

                                    Console.WriteLine("\nВведено неверное значение");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("Монумент уже активирован");
                            Console.ReadKey();
                        }
                        break;

                    case "2":
                        if (towerTimerTwo == 0)
                        {
                            Console.Clear();

                            Console.WriteLine("=== Монумент с лево ===");
                            Console.WriteLine("Загадочный столб с небольшим углублением под ключ");
                            Console.WriteLine("Подойти?");
                            Console.WriteLine("1)Попробовать активировать монумент\n" +
                                "0)Вернуться");
                            decision = Console.ReadLine();

                            switch (decision)
                            {
                                case "1":

                                    Console.Clear();

                                    towerTimerTwo = 1;

                                    SecondTower.TowerTwo(decision, ref mood, ref nameCharacter, ref luck);
                                    break;

                                default:

                                    Console.Clear();

                                    Console.WriteLine("\nВведено неверное значение");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("Монумент уже активирован");
                            Console.ReadKey();
                        }
                        break;

                    case "3":
                        if (towerTimerThree == 0)
                        {

                            Console.Clear();

                            Console.WriteLine("=== Монумент с лево ===");
                            Console.WriteLine("Загадочный столб с небольшим углублением под ключ");
                            Console.WriteLine("Подойти?");
                            Console.WriteLine("1)Попробовать активировать монумент\n" +
                                "0)Вернуться");
                            decision = Console.ReadLine();

                            switch (decision)
                            {
                                case "1":

                                    Console.Clear();

                                    towerTimerThree = 1;
                                    Third.TowerThree(nameCharacter, decision, ref littleHealsInInventory, ref heals, ref weapon, ref damageArm, ref damage, ref items, ref littleHealsPosion);
                                    break;

                                default:

                                    Console.Clear();

                                    Console.WriteLine("\nВведено неверное значение");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("Монумент уже активирован");
                        }
                        break;

                    case "4":
                        Console.Clear();

                        Console.WriteLine("=== Таинственный проход ===");
                        Console.WriteLine("Загадочный тёмный проход в конце которого виденслабый огонёк");
                        Console.WriteLine("Пройти в таинственный проход");
                        Console.WriteLine("1)Идти\n" +
                            "0)Остаться");
                        decision = Console.ReadLine();

                        switch (decision)
                        {
                            case "1":

                                Console.Clear();

                                Program.ArtefactsRoom(nameCharacter, heals, luck, artifact, mood, holeInBackpack, NumberOfArtifacts, decision);
                                NumberOfArtifacts = 1;
                                break;

                            default:

                                Console.Clear();

                                Console.WriteLine("\nВведено неверное значение");
                                Console.ReadKey();
                                break;
                        }
                        break;

                }

                Console.Clear();
            }
        }
    }
}
