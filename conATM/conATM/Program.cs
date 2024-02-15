using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PIN
            int PIN = 123456;
            int PINput;

            do
            {
                Console.Write("Enter PIN (6 characters): ");
                PINput = int.Parse(Console.ReadLine());
            } while (PINput != PIN);

            // Set Account
            Console.Write("PIN was a Success!");
            Console.Write("Set up account name: ");
            String acctName = Console.ReadLine();
            Console.Write("Set up account number: ");
            int acctNum = int.Parse(Console.ReadLine());
            Console.Write("Set up initial deposit: ");
            int acctBalance = int.Parse(Console.ReadLine());

            // Menu
            int selection;
            while (true)
            {
                Console.WriteLine("=== ROBIN BANKS LTD. ===");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Balance Inquiry");
                Console.WriteLine("3. Withdrawal");
                Console.WriteLine("4. Fast Cash");
                Console.WriteLine("5. Exit");
                Console.Write("Enter selection: ");
                selection = int.Parse(Console.ReadLine());
               
                switch (selection)
                {
                    case 5:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid. Try Again.");
                        break;
                }
            }
            
        }


    }
}
