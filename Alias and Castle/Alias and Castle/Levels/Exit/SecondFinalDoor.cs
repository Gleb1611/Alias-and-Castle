using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle.Levels.Exit
{
    internal class SecondFinalDoor
    {
        public static void SecondDoor(string nameCharacter, string decision)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Честно, я не придумал больше ничего.\n" +
                "Поэтому последние две будет из сюжета, который нам отправили");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();
            Console.WriteLine("Введите число:");

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    int value = Math.Abs(i - j);
                    Console.Write(value + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
