using System;
using System.Text.RegularExpressions;

namespace StringLetterCounting
{
    class Program
    {
        static void Main()
        {
            string letterCounting = Console.ReadLine();
            string newstr = letterCounting.Replace(" ", "");
            char[] letters = newstr.ToCharArray();

            int z = 0;
            
            int counter = 0;
            while (z != letters.Length - 1)
            {

                for (int i = 0; i < letters.Length; i++)
                {
                    char x = letters[z];

                    if (x == letters[i])
                    {
                        counter++;
                    }
                    if (i == letters.Length - 1)
                    {
                        z++;
                    }

                }
            }
            Console.WriteLine(counter + " - counter");
            Console.WriteLine("Массив после: " + string.Join(" ", letters));
        }
        
    }
}
