using AssemblyOne;

namespace AssemblyTwo
{
    class Triplecycle : Motorcycle
    {
        public Triplecycle() { }
   
        public Triplecycle(bool power, string motoBrand, string stateNumber, string motoColor, int tankValume, int gasValue, int odometer) : base(power, motoBrand, stateNumber, motoColor, tankValume, gasValue, odometer) { }

        static void Main()
        {
            bool power = true;
            string motoBrand = "Huenday- 3V";
            string stateNumber = "0100 MI -7";
            string motoColor = "black";
            int tankVolume = 200;
            int gasValue = 20;
            int odometer = 0;

            Triplecycle tripleHuenday = new Triplecycle(power, motoBrand, stateNumber, motoColor, tankVolume, gasValue, odometer);

            tripleHuenday.Print();
            tripleHuenday.Motion();
            tripleHuenday.Print();
            tripleHuenday.Refuel();
            tripleHuenday.Print();
            tripleHuenday.ColorMotorcycle();
        }
    }
}
