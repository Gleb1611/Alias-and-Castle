using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle
{
    internal class Third
    {
        public static void TowerThree(string nameCharacter, string decision, ref int littleHealsInInventory, ref int heals, ref string weapon, ref int damageArm, ref int damage, ref int items, ref int littleHealsPosion)
        {
            Console.WriteLine(nameCharacter + " подошёл к третьему монументу около которого был проход");
            Console.ReadKey();
            Console.WriteLine("За монументом есть табличка с надписью\n");
            Console.WriteLine("На табличке написано:\n");
            Console.WriteLine("То что ты ищешь находиться в конце этого тунеля");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine(nameCharacter + " проходить в таинственный проход");
            Console.ReadKey();

            Console.WriteLine("войдя в проход " + nameCharacter + " видит спуск со странными блестящими обломками");
            Console.ReadKey();
            Console.WriteLine("собрать обломки? (да / нет)");
            decision = Convert.ToString(Console.ReadLine());
            int fragmentsOfTheKey = 0;
            int fragmrntsNumber = 0;
            Random random = new Random();


            Steps.StairsWhitFragmentsOfTheKey(decision, random, ref fragmentsOfTheKey, ref nameCharacter, ref littleHealsInInventory, ref fragmrntsNumber);


            Console.WriteLine(nameCharacter + " дошёл(шла) до конца тунеля видит табличку");

            if (fragmentsOfTheKey > 9)
            {
                Console.WriteLine("У тебя уже есть ключ, который активирует последний монумент");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Последний артефакт был разделён на 10 частей и разбросан по всему проходу");
                Console.ReadKey();
            }

            string enemy = "Гоблин";
            int healsEnemy = 100;
            int damageEneme = 2;
            int CreedDamegeEnemy = damageEneme * 2;

            Console.WriteLine("возвращаясь обратно " + nameCharacter + $" натыкается на {enemy}");
            Console.ReadKey();


            Program.Fight(healsEnemy, random, heals, weapon, damageArm, damage, damageEneme, nameCharacter, littleHealsInInventory, items, littleHealsPosion, enemy, CreedDamegeEnemy);


            if (fragmentsOfTheKey < 10)
            {
                Console.Clear();

                Steps.StairsWhitFragmentsOfTheKey(decision, random, ref fragmentsOfTheKey, ref nameCharacter, ref littleHealsInInventory, ref fragmrntsNumber);
            }
        }
    }
}
