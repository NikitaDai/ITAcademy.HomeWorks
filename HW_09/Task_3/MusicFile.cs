using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class MusicFile : ComputerPrograms
    {
        private string _singer;
        private int _lenght;

        public string Singer { get; set; }
        public int Lenght { get; set; }

        public MusicFile(string name, string code, string category, int size, string singer, int lenght)
            :base(name, code, category, size)
        {
            Singer = singer;
            Lenght = lenght;
        }

        public void Play()
        {
        }

        public void RetrieveInformation()
        {
        }
      
        public override void GetInfo()
        {
            Console.WriteLine("Name file " + Name + " Code file " + Code + " Category file " + Category + " Size file " + Singer + " Singer " + Lenght + " Lenght ");
        }
    }
}
