using System;
using System.Collections.Generic;

namespace Task_1
{
    class Teacher : Person
    {
        private string _subject;

        private string Subject { get; set; }

        public Teacher()
        {
        }

        public Teacher(string subject, int n)
            :base(n)
        {
            Subject = subject;
        }

        public void Explain()
        {
            Console.WriteLine("Explanation  begins");
        }
    }
}
