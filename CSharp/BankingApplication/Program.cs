using System;

namespace BankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.Clear();
            Console.WriteLine("Welcome to Bank");
            Console.Write("Enter Bank Account number : ");
            ulong accountNumber = ulong.Parse(Console.ReadLine());
            User user = User.GetUserDetails(accountNumber);
            if (user == null)
            {
                byte createAccount;
                do
                {
                    Console.WriteLine("Not a valid user ! \n Wanted to create account: [0:No / 1:Yes]");
                    createAccount = byte.Parse(Console.ReadLine());
                } while (createAccount != 0 && createAccount != 1);
                if (createAccount == 1)
                {
                    User.CreateAccount();
                    goto start;
                } else
                {
                    Console.WriteLine("It is all good if you dont want to create account");
                }
                Console.WriteLine("Have a nice day !!");
                return;
            }

            TransactionMenu(user);

        }

        private static void TransactionMenu(User user)
        {
            int input = 1;
            while (input != 0)
            {
                displayOptions();
                Console.WriteLine("Choose a option __ : ");
                int.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    case 0:
                        break;
                    case 1:
                        // view Balance
                        Console.WriteLine("Your balance is : ");
                        break;
                    case 2:
                        break;
                    default:
                        Console.WriteLine("Enter a valid input");
                        break;
                }
            }
        }

        private static void displayOptions()
        {
            Console.WriteLine($"1: View Balance ");
            Console.WriteLine($"2: Deposit  ");
            Console.WriteLine($"3: Withdraw ");
            Console.WriteLine($"4: Transfer ");
            Console.WriteLine($"5: Create new trans. ");
            Console.WriteLine($"0: Exit ");
        }
    }
}
