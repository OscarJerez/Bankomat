namespace Bankomat
{
    public class BankAccount
    {
        public int BankAccountNumber { get; set; }

        public float BankAccountSaldo { get; set; }

        public int BankAcccountPinKod { get; set; }

        public BankAccount(int bankaccountnumber, float bankaccountsaldo, int pin)
        {
            BankAccountNumber = bankaccountnumber;
            BankAccountSaldo = bankaccountsaldo;
            BankAcccountPinKod = pin;
        }

        public void Deposit ()
        {
            int moneyToPutIn = UserInput();

            BankAccountSaldo = BankAccountSaldo + moneyToPutIn;

            Console.WriteLine($"Added this much - {moneyToPutIn} to your back account");

            Console.WriteLine($"Account balance is now : {BankAccountSaldo}");
        }

        public void Draw ()
        {
            int moneyToTakeOut = UserInput();

            BankAccountSaldo = BankAccountSaldo - moneyToTakeOut;

            Console.WriteLine($"You took out this much - {moneyToTakeOut} from your bank account");

            Console.WriteLine($"Account balance is now : {BankAccountSaldo}");
        }

        public void CheckBalance ()
        {
            Console.WriteLine($"Your bankaccount looks like this - {BankAccountSaldo}");
        }

        public int UserInput()
        {

            string moneyAsString = Console.ReadLine()!;

            int money = Convert.ToInt32(moneyAsString);

            return money;
        }
    }
}
