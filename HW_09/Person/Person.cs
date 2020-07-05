using System;
using System.Threading;

namespace Task_1
{
    class Person
    {
        public Person()
        {
            Age = 20;
        }

        public Person(int n)
        {
            Age = n;
        }

        private int _age;

        public int Age { get; set; }

        public void SetAge(int age)
        {
            Age = age;
        }

        public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
}
