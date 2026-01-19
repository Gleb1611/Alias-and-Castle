using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle.Levels.Exit
{
    internal class FirstFinalDoor
    {
        public static void FirstDoor(string nameCharacter, string decision, int capture)
        {
            Console.WriteLine("На двери написано:");
            Console.WriteLine("Просто повтори рисунок");

            Console.Clear();

            Console.WriteLine($"{nameCharacter}: сколько рядов было?");

            bool firstDoor = true;

            int number = 0;

            while(firstDoor)
            {
                number = int.Parse(Console.ReadLine());

                for (int i = 1; i < number; i++)
                {
                    Console.Write($"{i} ");
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }

                if (number == capture)
                {
                    Console.WriteLine("Дверь открылась");

                    firstDoor = false;
                }
                else
                {
                    Console.WriteLine("Что-от не пошло не так");
                }
            }
            

        }
    }
}
