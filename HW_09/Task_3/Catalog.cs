using System;
using System.Net.Http.Headers;

namespace Task_3
{
    class Catalog
    {
        private ComputerPrograms[] _arrayComputerPrograms;
        private Film[] _arrayFilm;
        private MusicFile[] _arrayMusicFile;

        public ComputerPrograms[] ArrayComputerPrograms { get; set; }
        public Film[] ArrayFilm { get; set; }
        public MusicFile[] ArrayMusicFile { get; set; }

        public Catalog()
        {
            ArrayComputerPrograms = new ComputerPrograms[3];
            ArrayComputerPrograms[0] = new ComputerPrograms { Name = "WOW", Code = "200200", Size = 4000, Category = "MMORPG" };
            ArrayComputerPrograms[1] = new ComputerPrograms { Name = "CS", Code = "1488", Size = 2000, Category = "Action" };
            ArrayComputerPrograms[2] = new ComputerPrograms { Name = "PhotoShop", Code = "121212", Size = 60000, Category = "ImageRedactor" };

            ArrayFilm = new Film[2];
            ArrayFilm[0] = new Film("Leatherman", "2000220", "Dram", 11110, "Stive Nolan", "BigFoot Man", "NAlla Big");
            ArrayFilm[1] = new Film("man", "2000123", "Action", 1111110, "Stive Nolan", "BigFoot Man", "NAlla Big");

            ArrayMusicFile = new MusicFile[2];
            ArrayMusicFile[0] = new MusicFile("Rock And Roll", "200200", "RAP", 123, "Boby Dilan", 36);
            ArrayMusicFile[1] = new MusicFile("Roll and Rock", "002002", "PAR", 321, "Nalid Ybob", 63);
        }

        public void Print()
        {
            for (int i = 0; i < ArrayComputerPrograms.Length; i++)
            {
                ArrayComputerPrograms[i].GetInfo();
            }

            for (int i = 0; i < ArrayMusicFile.Length; i++)
            {
                ArrayMusicFile[i].GetInfo();
            }

            for (int i = 0; i < ArrayFilm.Length; i++)
            {
                ArrayFilm[i].GetInfo();
            }
        }
    }
}
