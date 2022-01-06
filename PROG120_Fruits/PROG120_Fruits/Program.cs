using System;

namespace PROG120_Fruits
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit FruitOne = new Fruit(10, "Red");
            Fruit FruitTwo = new Fruit(15, "Green");
            Fruit FruitThree = new Fruit(7, "Yellow");
            Console.WriteLine("Fruit one weighs {0} and its color is {1}", FruitOne.Weight, FruitOne.Color);
            Console.WriteLine("Fruit one weighs {0} and its color is {1}", FruitTwo.Weight, FruitTwo.Color);
            Console.WriteLine("Fruit one weighs {0} and its color is {1}", FruitThree.Weight, FruitThree.Color);
        }
    }
    class Fruit
    {
        private int _Weight;
        private string _Color;

        public int Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public string Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        public Fruit(int pWeight, string pColor)
        {
            Weight = pWeight;
            Color = pColor;
        }
    }
}
