using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            bool power = true;
            string motoBrand = "Huenday";
            string stateNumber = "0000 MI -7";
            string motoColor = "pink";
            int tankVolume = 100;
            int gasValue = 10;
            int odometer = 2;

            Motorcycle motoHuenday = new Motorcycle(power, motoBrand, stateNumber, motoColor, tankVolume, gasValue, odometer);

            motoHuenday.Print();
            motoHuenday.Drive();
            motoHuenday.Print();
            motoHuenday.Motion();
            motoHuenday.Print();
            motoHuenday.ColorMotorcycle();
            motoHuenday.Print();
        }
    }
}
