using System;
using System.Diagnostics.Tracing;
using System.Text;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder task3 = new StringBuilder("1a!2.3!!.. 4.!.?6 7! ..?", 100);
            Console.WriteLine("Default string: " + task3);
            int counter = 0;

            for (int i = 0; i < task3.Length; i++)
            {

                if ((task3[i] == '!' && counter == 0) || (task3[i] == '.' && counter == 0))
                {
                    task3.Remove(i, 1);
                    i--;
                }

                else if (task3[i] == '?')
                {
                    counter = 1;
                }

                else if (task3[i] == ' ' && counter == 1)
                {
                    task3.Remove(i, 1);
                    task3.Insert(i, "_");
                }
            }
            Console.WriteLine("New string: " + task3);
        }
    }
}
