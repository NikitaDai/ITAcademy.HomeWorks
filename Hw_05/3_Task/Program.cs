using System;
using System.Linq;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };
            Console.WriteLine("Массив");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Array.Reverse(array);
            Console.WriteLine("Реверс массива");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
