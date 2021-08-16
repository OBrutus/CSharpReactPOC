using System;
using System.IO;

namespace BankingApplication
{
    internal class User
    {
        private ulong AccountNumber { get; set; }
        string Name { get; set; }
        ulong Balance { get; }

        private const string USERS_FILE_NAME = "Users.txt";
        private static ulong _lastAccountNumber=0L;

        private User(ulong balance)
        {
            this.Balance = balance;
        }

        public User(string row)
        {
            AccountNumber = getAccountNumber(row);
            Name = getName(row);
            Balance = getBalance(row);
        }

        public static User GetUserDetails(ulong accountNumber) {
            StreamReader sr = new StreamReader(new FileStream(USERS_FILE_NAME, FileMode.Open, FileAccess.Read));
            string row = sr.ReadLine();
            while(row != null)
            {
                if(getAccountNumber(row) == accountNumber)
                {
                    sr.Close();
                    return new User(row);
                }
            }
            sr.Close();
            return null;
        }

        private static ulong getAccountNumber(string row)
        {
            ulong number = 0;
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i] == ':')
                    break;
                if (row[i] > '9' || row[i] < '0')
                    throw new Exception("Bank Account inconsistent in data storage [file]");
                number = number * 10 + (uint)(row[i] - '0');
            }
            return number;
        }

        private ulong getBalance(string row)
        {
            int i = 0; 
            while(i < row.Length && row[i] != ':') i++;
            i++;
            while(i < row.Length && row[i] != ':') i++;
            if (i == row.Length) return 0;
            return ulong.Parse(row.Substring(i+1));
        }

        private string getName(string row)
        {
            int i = 0;
            while (i < row.Length && row[i] != ':') i++;
            String name = "";
            i++;
            while(i < row.Length && row[i] != ':')
            {
                name += row[i];
                i++;
            }
            return name;
        }

        public static User CreateAccount()
        {
            StreamWriter sw = new StreamWriter(new FileStream(USERS_FILE_NAME, FileMode.Append, FileAccess.Write));
            Console.WriteLine("Creating account");
            Console.Write("Enter name : ");
            string name = Console.ReadLine();
            Console.Write("Enter opening balance : ");
            ulong openingBalance = ulong.Parse(Console.ReadLine());
            _lastAccountNumber++;
            sw.WriteLine(_lastAccountNumber + ":" + name + ":" + openingBalance);
            sw.Close();
            User user = new User(openingBalance) { Name = name, AccountNumber = _lastAccountNumber };
            return user;
        }
     }
}