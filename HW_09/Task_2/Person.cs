using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Person
    {
        private string _name;
        private string _sex;
        private House _house;

        public string Name { get; set; }
        public string Sex { get; set; }

        public Person(string n, string s, House h)
        {
            Name = n;
            Sex = s;
            _house = h;
        }

        public void ShowData()
        {
            Console.WriteLine("Your name " + Name);
            Console.WriteLine("Your sex " + Sex);
            _house.ShowData();
            _house.doorHouse.ShowData();
        }
    }
}
