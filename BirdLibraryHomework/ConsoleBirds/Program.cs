using System;
using BirdLibrary;


namespace ConsoleBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what kind of bird did you see, Robin or Bluebird?");
            string birdType = Console.ReadLine().ToUpper(); 
            Console.WriteLine("How many did you see?");
            int birdCount = Convert.ToInt32(Console.ReadLine());

  
            Robin myRobin = null;
            Bluebird myBluebird = null;
            if (birdType == "ROBIN")
            {
                myRobin = new Robin();
                myRobin.Count = birdCount;
                // set common color proerty
            }
            else
            {
                myBluebird = new Bluebird();
                myBluebird.Count = birdCount;
                // set common color proerty
            }

            if (myRobin != null)
            {
                Console.WriteLine("I saw a {0} Robin and there were {1} of them", myRobin.CommonColor, myRobin.Count);
            }
            else
            {
                Console.WriteLine("I saw a {0} BlueBird and there were {1} of them", myBluebird.CommonColor, myBluebird.Count);
            }
        }
    }

   
}
