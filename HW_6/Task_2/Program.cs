using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Program program = new Program();
            program.Task2_1();
            program.Task2_2();
            program.Task2_3();
            program.Task2_4();
        }
        public void Task2_1()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] str2 = new string[str.Length - 1];
            string max = str[0];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > max.Length)
                {
                    max = str[i];
                }
            }

            for (int i = 0; i < str2.Length; i++)
            {
                str2[i] = str[i];

                if (str2[i] == max)
                {
                    str2[i] = str[i + 1];
                }
            }
            Console.WriteLine("Массив после: " + string.Join(" ", str2));
        }
        public void Task2_2()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string max = str[0];
            string min = str[0];
            int indexMax = 0;
            int indexMin = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > max.Length)
                {
                    max = str[i];
                    indexMax = i;
                }
                else if (str[i].Length <= min.Length)
                {
                    min = str[i];
                    indexMin = i;
                }
            }

            string temporary = str[indexMin];
            str[indexMin] = str[indexMax];
            str[indexMax] = temporary;

            Console.Write("Самое длинное слово: {0}", max);
            Console.WriteLine();
            Console.Write("Самое короткое слово: {0}", min);
            Console.WriteLine();
            Console.WriteLine("Массив после: " + string.Join(" ", str));
        }
        public void Task2_3()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';', '-' }, StringSplitOptions.RemoveEmptyEntries);
            int letterQuantity = 0;
            int letterQuantity2 = 0;

            for (int i = 0; i < str.Length; i++)
            {
                letterQuantity = str[i].Length + letterQuantity;
            }
            Console.WriteLine(letterQuantity);
            Console.WriteLine("Массив после: " + string.Join(" ", str));

            string[] str2 = input.Split(new char[] { ',', '.', ':', '!', '?', ';', '-' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < str2.Length; i++)
            {
                letterQuantity2 = str2[i].Length + letterQuantity2;
            }

            int symbolQuantity = input.Length - letterQuantity2;

            Console.WriteLine(symbolQuantity);
        }
        public void Task2_4()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';', '-' }, StringSplitOptions.RemoveEmptyEntries);
            int counter = 1;

            while (counter > 0 )
            {
                counter = 0;

                for (int i = 0; i < str.Length-1; i++)
                {
                    if (str[i].Length < str[i + 1].Length)
                    {   
                        string temporary = str[i];
                        str[i] = str[i + 1];
                        str[i + 1] = temporary;
                        counter ++;
                    }
                }
            }
            Console.WriteLine("Массив после: " + string.Join(" ", str));
        }
    } 
}  
