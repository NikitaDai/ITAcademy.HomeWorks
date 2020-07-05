using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task_2
{
    class Door
    {
        private string _color;

        public string Color { get; set; }

        public Door()
        {
            Color = "brown";
        }

        public Door(string n)
        {
            Color = n;
        }

        public void ShowData()
        {
            Console.WriteLine("I  am  a  door, my  color is " + Color);
        }
    }
}
