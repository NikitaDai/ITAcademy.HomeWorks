using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class ComputerPrograms
    {
        private string _name;
        private string _code;
        private string _category;
        private int _size;

        public string Name { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public int Size { get; set; }

        public ComputerPrograms()
        {
        }

        public ComputerPrograms(string name, string code, string category, int size)
        {
            Name = name;
            Code = code;
            Category = category;
            Size = size;
        }
        
        public virtual void GetInfo()
        {
            Console.WriteLine("Name file " + Name + " Code file " + Code + " Category file " + Category + " Size file " + Size);
        }
    }
}
