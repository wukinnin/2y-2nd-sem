using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

// Nimu Gonzaga, BSIT 2B
// #7

namespace conATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PIN
            int PIN = 123456;
            int PINput;
            double balance;

            do
            {
                Console.Write("Enter PIN (6 characters): ");
                PINput = int.Parse(Console.ReadLine());
                if (PINput != PIN)
                {
                    Console.WriteLine("Invalid PIN! Try again.");
                }
            } while (PINput != PIN);

            // Set Account
            Console.WriteLine("PIN was a Success!");
            Console.Write("Set up account name: ");
            String acctName = Console.ReadLine();
            Console.Write("Set up account number: ");
            int acctNum = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Set up initial deposit: ");
                balance = double.Parse(Console.ReadLine());
                if (balance % 100 != 0)
                {
                    Console.WriteLine("Amount must be divisible by 100. Try again.");
                }
            }
            while (balance % 100 != 0);
            

            // Menu
            int selection;
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("****** ROBIN BANKS LTD. ******");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Balance Inquiry");
                Console.WriteLine("3. Withdrawal");
                Console.WriteLine("4. Fast Cash");
                Console.WriteLine("5. Exit");
                Console.Write("Enter selection: ");
                selection = int.Parse(Console.ReadLine());
               
                // selection
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("");
                        balance = deposit(balance);
                        balanceInquiry(balance, acctName, acctNum);
                        break;
                    case 2:
                        balanceInquiry(balance, acctName, acctNum);
                        break;
                    case 3:
                        Console.WriteLine("");
                        balance = withdrawal(balance);
                        balanceInquiry(balance, acctName, acctNum);
                        break;
                    case 4:
                        Console.WriteLine("");
                        balance = fastCash(balance);
                        balanceInquiry(balance, acctName, acctNum);
                        break;
                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("Exiting program. Press Enter to exit.");
                        Console.ReadLine();
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Invalid. Try Again.");
                        break;
                }
            }
            
        }

        // balance inquiry
        static void balanceInquiry(double balance, String acctName, int acctNum)
        {
            Console.WriteLine("");
            Console.WriteLine("+++ Balance Inquiry +++");
            Console.WriteLine("");
            Console.WriteLine("Account Name: " + acctName);
            Console.WriteLine("Account Number: " + acctNum);
            Console.WriteLine("Your current balance is: " + balance);
        }

        // balance
        static double deposit(double balance)
        {
            double deposit;
            Console.WriteLine("--- Deposit Money ---");
            Console.WriteLine("");
            Console.WriteLine("Your current balance is: " + balance);
            do
            {
                Console.WriteLine("");
                Console.Write("Enter deposit amount: ");
                deposit = double.Parse(Console.ReadLine());
                if(deposit % 100 != 0)
                {
                    Console.WriteLine("Amount must be divisible by 100. Try again.");
                }
            }
            while (deposit % 100 != 0);

            Console.WriteLine("");
            Console.Write("Sure to deposit " + deposit + "? [Y/N]: ");
            char depSelection = char.Parse(Console.ReadLine().ToUpper());

            if (depSelection == 'Y')
            {
                balance = balance + deposit;
                return balance;
            }
            else
            {
                Console.WriteLine("Declined. Returning to menu.");
                return balance;
            }
        }

        // withdrawal
        static double withdrawal(double balance)
        {
            double withdrawal;
            Console.WriteLine("--- Withdraw Money ---");
            Console.WriteLine("");
            Console.WriteLine("Your current balance is: " + balance);
            do
            {
                Console.WriteLine("");
                Console.Write("Enter withdrawal amount: ");
                withdrawal = double.Parse(Console.ReadLine());
                if (withdrawal % 100 != 0)
                {
                    Console.WriteLine("Amount must be divisible by 100. Try again.");
                }
            }
            while (withdrawal % 100 != 0);

            Console.WriteLine("");
            Console.Write("Sure to withdraw " + withdrawal + "? [Y/N]: ");
            char depSelection = char.Parse(Console.ReadLine().ToUpper());

            if (depSelection == 'Y')
            {
                balance = balance - withdrawal;
                return balance;
            }
            else
            {
                Console.WriteLine("Declined. Returning to menu.");
                return balance;
            }
        }

        // fast cash
        static double fastCash(double balance)
        {
            Console.WriteLine("Your current balance is: " + balance);

            int fcSelection;
            
            while(true)
            {
                Console.WriteLine("--- Fast Cash Withdrawal ---");
                Console.WriteLine("1. 1000");
                Console.WriteLine("2. 2000");
                Console.WriteLine("3. 5000");
                Console.WriteLine("4. 10000");
                Console.WriteLine("5. Exit");
                Console.Write("Enter selection: ");
                fcSelection = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                switch (fcSelection)
                {
                    
                    case 1:
                        Console.Write("Sure to withdraw 1000? [Y/N]: ");
                        /* initial declare */ char ynFCSelection = char.Parse(Console.ReadLine().ToUpper());

                        if (ynFCSelection == 'Y')
                        {
                            balance = balance - 1000;
                            return balance;
                        }
                        else
                        {
                            Console.WriteLine("Declined. Returning to menu.");
                            return balance;
                        }
                    case 2:
                        Console.Write("Sure to withdraw 2000? [Y/N]: ");
                        ynFCSelection = char.Parse(Console.ReadLine().ToUpper());

                        if (ynFCSelection == 'Y')
                        {
                            balance = balance - 2000;
                            return balance;
                        }
                        else
                        {
                            Console.WriteLine("Declined. Returning to menu.");
                            return balance;
                        }
                    case 3:
                        Console.Write("Sure to withdraw 5000? [Y/N]: ");
                        ynFCSelection = char.Parse(Console.ReadLine().ToUpper());

                        if (ynFCSelection == 'Y')
                        {
                            balance = balance - 5000;
                            return balance;
                        }
                        else
                        {
                            Console.WriteLine("Declined. Returning to menu.");
                            return balance;
                        }
                    case 4:
                        Console.Write("Sure to withdraw 10000? [Y/N]: ");
                        ynFCSelection = char.Parse(Console.ReadLine().ToUpper());

                        if (ynFCSelection == 'Y')
                        {
                            balance = balance - 10000;
                            return balance;
                        }
                        else
                        {
                            Console.WriteLine("Declined. Returning to menu.");
                            return balance;
                        }
                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("Declined. Returning to menu");
                        return balance;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Invalid. Try again.");
                        break;
                }
            }
        }
    }
}
