using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("\nВведите W для движения вперед. \nВведите S для движения назад. \nВведите A для движения налево. \nВведите D для движения направо. \nДля выхода напишите Exit");
                string move = Console.ReadLine();

                switch (move)
                {
                    case "w":
                        Console.WriteLine("ВПЕЕРЕЕЕЕД!");
                        break;

                    case "s":
                        Console.WriteLine("Ах, терпеть не могу движения назад...");
                        break;

                    case "a":
                        Console.WriteLine("Налево? А уверен, что жена не узнает?");
                        break;

                    case "d":
                        Console.WriteLine("ВПЕРЕЕЕД!Толко чуть-чуть правее...");
                        break;

                    case "Exit":
                        Console.WriteLine("Выхожу в реальный мир");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Вот сам туда и иди, а я останусь тут!");
                        break;
                }
            }
        }
    }
}
