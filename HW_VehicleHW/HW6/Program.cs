using System;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] array = new Vehicle[4];

            array[0] = new Car("Red", 2000);
            array[1] = new Car("Blue", 2022);
            array[2] = new Truck("Black", 1990);
            array[3] = new Truck("White", 2010);

            int count = 0;
            foreach (Vehicle item in array)
            {
                array[count].Print();
                count++;
            }
        }
    }
    class Vehicle
    {
        private string _Color;
        private int _Year;

        public string Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        public int Year
        {
            get { return _Year; }
            set { _Year = value; }
        }

        public virtual void Print()
        {
            Console.WriteLine("There is a bug in your program");
        }
    }

    class Car : Vehicle
    {
        public Car(string pColor, int pYear)    //Constructor
        {
            Color = pColor;
            Year = pYear;
        }

        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The color of this vehicle is {Color} and its model year is {Year}");
            Console.ResetColor();
        }
    }

    class Truck : Vehicle
    {
        public Truck(string pColor, int pYear)    //Constructor
        {
            Color = pColor;
            Year = pYear;
        }
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The color of this vehicle is {Color} and its model year is {Year}");
            Console.ResetColor();
        }
    }
}