using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetassessment
{
    public class BankAccount
    {
        public static void Main(string[] args)
        {
            double balance = 0;
            Console.WriteLine("Enter the account holder name:");
            string accountHolderName = Console.ReadLine();
            Console.WriteLine("Enter the account number:");
            int accountNumber = int.Parse(Console.ReadLine());

            bool option = true;

            while (option)
            {
                Console.WriteLine("Press 1 for deposit and 2 for withdrawal");
                byte numberOne = byte.Parse(Console.ReadLine());

                if (numberOne == 1)
                {
                    Console.WriteLine("Enter the deposit amount:");
                    double depositMoney = double.Parse(Console.ReadLine());
                    balance = deposit(depositMoney, balance);
                    accountDetails(accountHolderName, accountNumber, balance);

                }
                else if (numberOne == 2)
                {
                    Console.WriteLine("Enter the withdrawal amount:");
                    double withdrawalMoney = double.Parse(Console.ReadLine());
                    balance = withdrawal(withdrawalMoney, balance);
                    accountDetails(accountHolderName, accountNumber, balance);
                }
                else
                {
                    Console.WriteLine("Please enter the correct number.");
                }

                Console.WriteLine("Do you want to continue? Press y for Yes and n for No");
                string finalResponse = Console.ReadLine();
                if (finalResponse.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    option = false;
                }

                Console.WriteLine("Thank you have a nice day");
            }

        }

        public static double deposit(double depositMoney, double balance)
        {
            balance += depositMoney;
            return balance;
        }

        public static double withdrawal(double withdrawalMoney, double balance)
        {
            if (withdrawalMoney <= balance)
            {
                balance -= withdrawalMoney;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
            return balance;
        }

        public static void accountDetails(string accountHolderName, int accountNumber, double balance)
        {
            Console.WriteLine("Account Holder Name: {0}\nAccount Number: {1}\nAccount Balance: {2}\n", accountHolderName, accountNumber, balance);
        }

    }
}