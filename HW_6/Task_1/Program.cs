using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] textArray = text.Split(new char[] {';'});

            for (int i = 0; i < textArray.Length; i++)
            {
                Console.WriteLine(textArray[i].Replace('o', 'a').Replace('O','A')); ;
            }
        }
    }
}
