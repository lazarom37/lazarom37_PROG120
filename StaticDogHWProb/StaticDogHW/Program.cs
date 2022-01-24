using System;

namespace StaticDogHW
{
    class Program
    {
        static void Main(string[] args)
        {
            // will have 3 Dogs
            Dog[] allDogs = new Dog[3];
            allDogs[0] = new Dog(20f, 10f, "Fido");
            allDogs[1] = new Dog(40f, 20f, "Percy");
            allDogs[2] = new Dog(70f, 30f, "Snoopy");

            // comment out the next 3 lines until you have written the Dog class and the code runs ok
            // then put these 3 lines back in after you write your static class
            Console.WriteLine("{0} is healthy: {1}", allDogs[0].Name, HealthCheck.IsHealthy(allDogs[0]));
            Console.WriteLine("{0} is healthy: {1}", allDogs[1].Name, HealthCheck.IsHealthy(allDogs[1]));
            Console.WriteLine("{0} is healthy: {1}", allDogs[2].Name, HealthCheck.IsHealthy(allDogs[2]));

            Console.ReadLine();
        }
    }  //  end of class Program

    //========================================================
    class Dog
    {
        private float _Weight;
        private float _Height;
        private string _Name;
        public float Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }
        public float Height
        {
            get { return _Height; }
            set { _Height = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public Dog (float pWeight, float pHeight, string pName)
        {
            Weight = pWeight;
            Height = pHeight;
            Name = pName;
        }
    }
    //========================================================
    static class HealthCheck
    {
        public static bool IsHealthy(Dog pDog)
        {
            if ((pDog.Weight / pDog.Height) > 2)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
    //========================================================
}