using System.Diagnostics;

namespace Bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(11112222, 50000, 1234);

            PrintOutLoginMeny();

            string optionChoosed = Console.ReadLine()!;

            if (optionChoosed == "1")
            {
                // Trying to log in
                Console.WriteLine("Please enter your PIN Code");

                int pinKod = Convert.ToInt32(Console.ReadLine()!);

                if(account.BankAcccountPinKod == pinKod)
                {
                    // WE HAVE LOGED IN
                    LogedInMeny(account);
                }
                else
                {
                    Console.WriteLine("Please try again, wrong PIN CODE");
                }
            }

            // When logged in, show other meny
        }

        private static void LogedInMeny(BankAccount account)
        {
            PrintOutBasicMeny();

            string logedInOption = Console.ReadLine()!;

            if (logedInOption == "1")
            {
                // We want to check account balance
                account.CheckBalance();

            }
            else if (logedInOption == "2")
            {
                Console.WriteLine("Write how much you want to add");

                account.Deposit();

            }
            else if (logedInOption == "3")
            {
                Console.WriteLine("Write how much you want to take out");

                account.Draw();

            };
        }

        private static void PrintOutBasicMeny()
        {
            Console.WriteLine("Welcome to Nemo ATM Bankomat");
            Console.WriteLine("Choose an option from the meny");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - Check Balance");
            Console.WriteLine("2 - Deposit Money");
            Console.WriteLine("3 - Withdraw Money");
            Console.WriteLine("4 - Log out");
        }
        private static void PrintOutLoginMeny()
        {
            Console.WriteLine("Welcome to Nemo ATM Bankomat");
            Console.WriteLine("Choose an option from the meny");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - Log in");
            Console.WriteLine("2 - Exit");
        }   
    }
}
