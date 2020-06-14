using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] secondMassive = new int[5];

            for (int i = 0; i < secondMassive.Length - 1; i++)
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                secondMassive[i] = num1;
            }
            Console.WriteLine("[{0}]", string.Join(", ", secondMassive));

            Console.WriteLine("Введите значение элемента массива");
            secondMassive[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите позицию в массиве");
            int k = Convert.ToInt32(Console.ReadLine());

            while (k > secondMassive.Length)
            {
                Console.WriteLine("Длина массива = 5 элементам, введите значение в этом диапозоне");
                k = Convert.ToInt32(Console.ReadLine());
            }

            int[] firstMassive = new int[secondMassive.Length];

            for (int i = 0; i < secondMassive.Length; i++)
            {
                firstMassive[(i + k) % firstMassive.Length] = secondMassive[i];
            }
            Console.WriteLine("[{0}]", string.Join(", ", firstMassive));
        }
    }
}
