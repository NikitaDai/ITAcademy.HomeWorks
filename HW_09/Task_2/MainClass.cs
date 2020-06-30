using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class MainClass
    {
        static void Main()
        {
            SmallApartment smallApp = new SmallApartment();
            Person alex = new Person("Alex", "Male", smallApp);
            alex.ShowData();
        }
    }
}
