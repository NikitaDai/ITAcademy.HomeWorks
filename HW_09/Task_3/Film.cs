using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Film : ComputerPrograms
    {
        private string _director;
        private string _maineActor;
        private string _maineActress;

        public string Director { get; set; }
        public string MaineActor { get; set; }
        public string MaineActress { get; set; }

        public Film(string name, string code, string category, int size, string director, string maineActor, string maineActress)
            : base(name, code, category, size)
        {
            Director = director;
            MaineActor = maineActor;
            MaineActress = maineActress;
        }

        public void Play()
        {
        }

        public void RetrieveInformation()
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine("Name file " + Name + " Code file " + Code + " Category file " + Category + " Size file " + Director + " Director " + MaineActor + " MaineActor " + MaineActress + " MaineActress ");
        }
    }
}
