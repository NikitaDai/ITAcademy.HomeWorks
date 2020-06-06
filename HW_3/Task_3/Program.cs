using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDate;
            while (!DateTime.TryParse(Console.ReadLine(), out birthDate))
            {
                Console.WriteLine("Введите дату в формате: {0:d}", new DateTime(2000, 1, 1));
            }
            DateTime nowDate = DateTime.Now;
            int age = nowDate.Year - birthDate.Year;
            if (birthDate > nowDate.AddYears(-age)) age--;
            Console.WriteLine("Ваш возраст " + age + " года/лет");
        }
    }
}
