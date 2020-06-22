using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив с рандомными элементами");
            Random numRandom = new Random();
            int[] firstMassive = new int[10];
            for (int i = 0; i < firstMassive.Length; i++)
            {
                int num1 = numRandom.Next(0, 100);
                firstMassive[i] = num1;
            }
            Console.WriteLine("[{0}]", string.Join(", ", firstMassive));

            Console.WriteLine("Введите значения элементов массива");
            int[] secondMassive = new int[10];
            for (int i = 0; i < secondMassive.Length; i++)
            {
                int num3 = Convert.ToInt32(Console.ReadLine());
                secondMassive[i] = num3;
            }
            Console.WriteLine("Массив элементов значение которых ввели с клавиатуры");
            Console.WriteLine("[{0}]", string.Join(", ", secondMassive));

            int[] resultMassive = new int[10];
            for (int i = 0; i < resultMassive.Length; i++)
            {
                resultMassive[i] = firstMassive[i] + secondMassive[i];
            }
            Console.WriteLine("Сумма значений элементов первого и второго массива");
            Console.WriteLine("[{0}]", string.Join(", ", resultMassive));
        }
    }
}
