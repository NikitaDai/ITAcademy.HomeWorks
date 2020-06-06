using System;

namespace Task_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Summ();
            Calculator.Sub();
            Calculator.Mult();
            Calculator.Div();
            Calculator.Balance();
            Calculator.Area();
        }
    }
    public static class Calculator
    {
        public static void Summ()
        {
            Console.WriteLine("Операция суммирования");
            Console.WriteLine("Введите первое число ");
            double firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondValue = Convert.ToDouble(Console.ReadLine());
            double resultSumm = firstValue + secondValue;
            Console.WriteLine("Результат суммирования равен " + resultSumm);
        }
        public static void Sub()
        {
            Console.WriteLine("Операция вычитания");
            Console.WriteLine("Введите первое число ");
            double firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondValue = Convert.ToDouble(Console.ReadLine());
            double resultSub = firstValue - secondValue;
            Console.WriteLine("Результат вычитания равен " + resultSub);
        }

        public static void Mult()
        {
            Console.WriteLine("Операция умножения");
            Console.WriteLine("Введите первое число ");
            double firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondValue = Convert.ToDouble(Console.ReadLine());
            double resultMult = firstValue * secondValue;
            Console.WriteLine("Результат умножения равен " + resultMult);
        }
        public static void Div()
        {
            Console.WriteLine("Операция деления");
            Console.WriteLine("Введите первое число ");
            double firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondValue = Convert.ToDouble(Console.ReadLine());
            double resultDiv = firstValue / secondValue;
            Console.WriteLine("Результат деления равен " + resultDiv);
        }
        public static void Balance()
        {
            Console.WriteLine("Остаток от деления");
            Console.WriteLine("Введите первое число ");
            double firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondValue = Convert.ToDouble(Console.ReadLine());
            double resultBalance = firstValue % secondValue;
            Console.WriteLine("Остаток от деления равен " + resultBalance);
        }
        public static void Area()
        {
            Console.WriteLine("Площадь круга");
            Console.WriteLine("Введите радиус круга ");
            double r = Convert.ToDouble(Console.ReadLine());
            double resultArea = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Площадь курга равна " + resultArea);
        }
    }
}
