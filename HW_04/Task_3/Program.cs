using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Calculator();
        }

        public void Calculator()
        {
            double firstValue = 0;
            double secondValue = 0;
            double answer = 0;
            bool validation = true;
            bool secondValidation = true;
            bool thirdValidation = true;
            bool fourthValidation = true;
            string retry = "No";

            Console.WriteLine("Введите первое число ");

            while (validation == true)
            {
                try
                {
                    firstValue = Convert.ToDouble(Console.ReadLine());
                    validation = false;
                }
                catch
                {
                    Console.WriteLine("Введите значение в формате : 00,00");
                }
            }

            Console.WriteLine("Введите второе число");

            while (secondValidation == true)
            {
                try
                {
                    secondValue = Convert.ToDouble(Console.ReadLine());
                    secondValidation = false;
                }
                catch
                {
                    Console.WriteLine("Введите значение в формате : 00,00");
                }
            }

            while (retry != "Yes")
            {
                Console.WriteLine("\nВведите 1 для сложения введенных чисел \nВведите 2 для разности введенных чисел \nВведите 3 для выхода их программы");
                string i = Console.ReadLine();

                switch (i)
                {
                    case "1":
                        string retryAnswer = "No";
                        double resultSumm = firstValue + secondValue;
                        Console.WriteLine("А сам как думаешь? ");

                        while (retryAnswer != "Yes")
                        {
                            while (thirdValidation == true)
                            {
                                try
                                {
                                    answer = Convert.ToDouble(Console.ReadLine());
                                    thirdValidation = false;
                                }
                                catch
                                {
                                    Console.WriteLine("Соберись и введи в нужном формате");
                                }
                            }

                            if (answer == resultSumm)
                            {
                                retryAnswer = "Yes";
                                Console.WriteLine("Правильно! И зачем тебе калькулятор?");
                            }
                            else if (resultSumm < answer)
                            {
                                Console.WriteLine("Ты преувеличиваешь...Посчитай еще раз");
                                thirdValidation = true;
                            }
                            else if (resultSumm > answer)
                            {
                                Console.WriteLine("Ты недооцениваешь своих возможностей, добавь еще немного");
                                thirdValidation = true;
                            }
                        }
                        break;


                    case "2":
                        string retryAnswerSub = "No";
                        double resultSub = firstValue - secondValue;
                        Console.WriteLine("А сам как думаешь? ");

                        while (retryAnswerSub != "Yes")
                        {
                            while (fourthValidation == true)
                            {
                                try
                                {
                                    answer = Convert.ToInt32(Console.ReadLine());
                                    fourthValidation = false;
                                }

                                catch
                                {
                                    Console.WriteLine("Соберись и введи в нужном формате");
                                }
                            }

                            if (answer == resultSub)
                            {
                                retryAnswerSub = "Yes";
                                Console.WriteLine("Правильно! И зачем тебе калькулятор?");
                            }
                            else if (resultSub < answer)
                            {
                                Console.WriteLine("Ты преувеличиваешь...Посчитай еще раз");
                                fourthValidation = true;
                            }
                            else if (resultSub > answer)
                            {
                                Console.WriteLine("Ты недооцениваешь своих возможностей, добавь еще немного");
                                fourthValidation = true;
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("Выход из программы");
                        retry = "Yes";
                        break;

                    default:
                        Console.WriteLine("Ты не можешь ввести число?!");
                        break;
                }
            }
        }
    }
}
