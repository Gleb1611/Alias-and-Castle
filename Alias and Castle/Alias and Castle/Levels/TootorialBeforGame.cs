using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle.Levels
{
    internal class TootorialBeforGame
    {
        public static void Totorial()
        {
            Console.WriteLine("Обучение\n" +
               "Для продолжения нажмите Enter ");

            Console.ReadKey();

            Console.WriteLine("Для выбора действия введите число, затем нажмите Enter ");
            Console.ReadKey();
            string traningNumber = "";
            int checkingTheEnteredNumberInTraining = 0;

            while (checkingTheEnteredNumberInTraining == 0)
            {
                Console.Clear();

                Console.WriteLine("Пример:");
                Console.WriteLine("Выбирите действие:");

                checkingTheEnteredNumberInTraining = 0;
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"{i})действие");
                }
                Console.WriteLine("\nВы должны ввести любое число из списка");
                traningNumber = Console.ReadLine();

                switch (traningNumber)
                {
                    case "1":
                    case "2":
                    case "3":
                        checkingTheEnteredNumberInTraining = 1;
                        break;
                    default:
                        Console.Clear();

                        Console.WriteLine("\nВы ввели недоступное число");
                        Console.ReadKey();

                        Console.Clear();
                        break;
                }
            }
            Console.Clear();

            Console.WriteLine("Если вы видите (да / нет), то вам следует ввести да или нет");
            Console.ReadKey();


            for (int i = 1; i < 3;)
            {
                while (i <= 3)
                {
                    switch (i)
                    {
                        case 1:
                            Console.Clear();

                            Console.WriteLine("Пример:\n");

                            Console.WriteLine("Следует ли вовремя делать домашнее задание? (да / нет):");
                            traningNumber = Console.ReadLine();
                            if (traningNumber.ToLower() == "да" || traningNumber.ToLower() == "д" || traningNumber.ToLower() == "а")
                            {
                                Console.WriteLine("Правильно! Давай перейдём к следующему заданию");
                                i++;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Не верно, попробуй ещё раз");
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Вы добровольно играете в эту игру, (да / нет):");
                            traningNumber = Console.ReadLine();
                            if (traningNumber.ToLower() == "да" || traningNumber.ToLower() == "д" || traningNumber.ToLower() == "а")
                            {
                                Console.WriteLine("Правильно! Давай перейдём к следующему заданию");
                                i++;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Не верно, попробуй ещё раз");
                                Console.ReadKey();
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Вы одни в комнате? (да / нет):");
                            traningNumber = Console.ReadLine();
                            if (traningNumber.ToLower() == "да" || traningNumber.ToLower() == "д" || traningNumber.ToLower() == "а")
                            {
                                Console.Clear();
                                Console.WriteLine("Не верно, попробуй ещё раз");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Правильно!");
                                i++;
                                checkingTheEnteredNumberInTraining = 1;
                            }
                            break;
                    }
                }

            }

            Console.Clear();

            Console.WriteLine("Поздравляю, вы прошли всё обучение(которое есть на данный момент)");
            Console.ReadKey();
        }
    }
}
