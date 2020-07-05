using System;
using System.Collections.Generic;

namespace Task_1
{
    class Student : Person
    {
        public Student()
        {
        }

        public Student(int n)
        {
            Age = n;
        }

        public void GoToClasses()
        {
            Console.WriteLine("I’m going to class.");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is : " + Age + " years;");
        }
    }
}
