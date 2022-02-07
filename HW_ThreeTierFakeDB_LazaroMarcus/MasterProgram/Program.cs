using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface appUserInterface = new UserInterface();
            appUserInterface.Start();
            Console.ReadLine();
        }
    }
}
