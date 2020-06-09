using System;
using System.Collections.Generic;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            int letter = 65;

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)letter;

                if (i < alphabet.Length -1)
                {
                    letter++;
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", alphabet));

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)letter;
                letter--;
            }

            Console.WriteLine("[{0}]", string.Join(", ", alphabet));
        }
    }
}
