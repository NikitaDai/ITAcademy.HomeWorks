using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator program = new Calculator();
            program.Summ();
            program.Sub();
            program.Mult();
            program.Div();
            program.Balance();
            program.Area();
        }
    }
    class Calculator
    {
        public double Summ()
        {
            Console.WriteLine("Операция суммирования");
            Console.WriteLine("Введите первое число ");
            double firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondValue = Convert.ToDouble(Console.ReadLine());
            double resultSumm = firstValue + secondValue;
            Console.WriteLine("Результат суммирования равен " + resultSumm);
            return resultSumm;
        }

        public double Sub()
        {
            Console.WriteLine("Операция вычитания");
            Console.WriteLine("Введите первое число ");
            double firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondValue = Convert.ToDouble(Console.ReadLine());
            double resultSub = firstValue - secondValue;
            Console.WriteLine("Результат вычитания равен " + resultSub);
            return resultSub;
        }

        public double Mult()
        {
            Console.WriteLine("Операция умножения");
            Console.WriteLine("Введите первое число ");
            double firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondValue = Convert.ToDouble(Console.ReadLine());
            double resultMult = firstValue * secondValue;
            Console.WriteLine("Результат умножения равен " + resultMult);
            return resultMult;
        }
        public double Div()
        {
            Console.WriteLine("Операция деления");
            Console.WriteLine("Введите первое число ");
            double firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondValue = Convert.ToDouble(Console.ReadLine());
            double resultDiv = firstValue / secondValue;
            Console.WriteLine("Результат деления равен " + resultDiv);
            return resultDiv;
        }
        public double Balance()
        {
            Console.WriteLine("Остаток от деления");
            Console.WriteLine("Введите первое число ");
            double firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondValue = Convert.ToDouble(Console.ReadLine());
            double resultBalance = firstValue % secondValue;
            Console.WriteLine("Остаток от деления равен " + resultBalance);
            return resultBalance;
        }
        public double Area()
        {
            Console.WriteLine("Площадь круга");
            Console.WriteLine("Введите радиус круга ");
            double r = Convert.ToDouble(Console.ReadLine());
            double resultArea = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Площадь курга равна " + resultArea);
            return resultArea;
        }
    }
}
