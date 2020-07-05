using System;

namespace Task_2
{
    class House
    {
        private int _area;
        internal Door doorHouse;

        public int Area { get; set; }

        public House()
        {
            Area = 200;
            doorHouse = new Door();
        }

        public House(int n, Door door)
        {
            Area = n;
            doorHouse = door;
        }

        public void ShowData()
        {
            Console.WriteLine("I  am  a  house,  my  area  is " + Area + " m");
        }

        public Door GetDoor()
        {
            return doorHouse;
        }
    }
}
