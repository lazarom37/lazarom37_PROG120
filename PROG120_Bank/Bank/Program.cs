using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first name");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter last name");
            string name2 = Console.ReadLine();
            SavingsAccount AccountOne = new SavingsAccount(name1, name2);
            AccountOne.Balance = 10;

            SavingsAccount AccountTwo = new SavingsAccount();
            Console.WriteLine("Enter first name");
            AccountTwo.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            AccountTwo.LastName = Console.ReadLine();
            AccountTwo.Balance = 10;


            SavingsAccount AccountThree = new SavingsAccount();
            Console.WriteLine("Enter first name");
            AccountThree.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            AccountThree.LastName = Console.ReadLine();
            AccountThree.Balance = 10;

            bool success = false;
            success = AccountTwo.Deposit(30); //40
            if (!success)
            {
                Console.WriteLine("Sorry, that failed");
            }
            else
                {
                Console.WriteLine("Thank you");
            }

            Console.WriteLine(AccountOne.FirstName + " " + AccountOne.LastName + " has $" + AccountOne.Balance);
            Console.WriteLine(AccountTwo.FirstName + " " + AccountTwo.LastName + " has $" + AccountTwo.Balance);
            Console.WriteLine(AccountThree.FirstName + " " + AccountThree.LastName + " has $" + AccountThree.Balance);

        }
    }

    class SavingsAccount
    {
        string _FirstName;
        private string _LastName;
        private decimal _Balance;

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public decimal Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }

        public SavingsAccount(string pFname, string pLname)    //This is a constructor, constructors cannot return anything
        {
            _FirstName = pFname;
            _LastName = pLname;
            _Balance = 10;
        }

        public bool Deposit(decimal pValue)
        {
            _Balance = _Balance + pValue;
            return true;
        }
    }
}