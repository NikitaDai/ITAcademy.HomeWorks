using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Task_2
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
            string retry = "No";

            Console.WriteLine("Введите первое число ");
            int firstValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int secondValue = Convert.ToInt32(Console.ReadLine());

            while (retry != "Yes")
            {
                Console.WriteLine("Введите 1 для сложения введенных чисел \nВведите 2 для разности введенных чисел \nВведите 3 для выхода их программы");
               
                string i = Console.ReadLine();

                switch (i)
                {
                    case "1":
                        int resultSumm = firstValue + secondValue;
                        Console.WriteLine("А сам как думаешь? ");
                        int answer = Convert.ToInt32(Console.ReadLine());

                        if (answer == resultSumm)
                        {
                            Console.WriteLine("И зачем тебе калькулятор?");
                        }
                        else
                        {
                            Console.WriteLine("Да, калькулятор тебе не помешает...результат суммы = " + resultSumm);
                        }
                        break;

                    case "2":
                        int resultSub = firstValue - secondValue;
                        Console.WriteLine("А сам как думаешь? ");
                        int answerSub = Convert.ToInt32(Console.ReadLine());

                        if (answerSub == resultSub)
                        {
                            Console.WriteLine("И зачем тебе калькулятор?");
                        }
                        else
                        {
                            Console.WriteLine("Да, калькулятор тебе не помешает...результат суммы = " + resultSub);
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
