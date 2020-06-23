using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace AssemblyOne
{
    public class Motorcycle
    {
        private bool _power;
        private string _stateNumber;
        private string _motoColor;
        private int _tankVolume;
        private int _gasValue;
        private int _odometer;

        public Motorcycle()
        {
            this.MotoBrand = "Honda";
            this.Power = true;
            this.StateNumber = "5566 - AH -7";
            this.MotoColor = "Red";
            this.TankVolume = 16;
            this.GasValue = 16;
            this.Odometer = 0;
        }

        public Motorcycle(bool power, string motoBrand, string stateNumber, string motoColor, int tankValume, int gasValue, int odometer)
        {
            this.MotoBrand = motoBrand;
            this.Power = power;
            this.StateNumber = stateNumber;
            this.MotoColor = motoColor;
            this.TankVolume = tankValume;
            this.GasValue = gasValue;
            this.Odometer = odometer;
        }

        public string MotoBrand { get; set; }
        public string StateNumber { get; set; }
        public string MotoColor { get; set; }
        public int TankVolume { get; set; }
        public bool Power { get; set; }
        public int GasValue
        {
            get
            {
                return _gasValue;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Fuel cannot be < 0");
                }

                else if (value > TankVolume)
                {
                    Console.WriteLine("Gas overflow");
                }

                else
                {
                    _gasValue = value;
                }
            }
        }

        public int Odometer
        {
            get
            {
                return _odometer;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Wrong mileage");
                }

                else
                {
                    _odometer = value;
                }
            }
        }

        internal void Drive()
        {
            if (Power == true)
            {
                Console.WriteLine("Your motorcycle has been already started. Gas value -1");
                GasValue--;
            }

            else if (Power == false)
            {
                Console.WriteLine("Нow can you drive with stopped engine");
            }
        }

        public void Motion()
        {
            if (Power == true)
            {
                Odometer = Odometer + 10;
                GasValue--;
            }

            else if (Power == false)
            {
                Console.WriteLine("You can not go anywhere with stopped engine ");
            }
        }

        protected void Refuel()
        {
            if (GasValue == 0)
            {
                Console.WriteLine("Need refuel");
            }

            else
            {
                Console.WriteLine("Fuel is normal");
            }
        }

        private void MotoStateNumber()
        {
            StateNumber = "4477 AK - 7";
        }

        protected internal void ColorMotorcycle()
        {
            MotoColor = "Green";
        }

        private protected void MotorcycleBrand()
        {
            MotoBrand = "Suzuki";
        }

        public void Print()
        {
            Console.WriteLine("\nЗаведен ли двигатель? " + Power + "\nМото бренд " + MotoBrand + "\nГос. номер " + StateNumber + "\nЦвет " + MotoColor + "\nОбем бака " + TankVolume + "\nОбьем топлива " + GasValue + "\nПробег " + Odometer);
        }
    }
}
