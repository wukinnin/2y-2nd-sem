using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conDenom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cash;
            Console.Write("Enter cash: ");
            cash = int.Parse(Console.ReadLine());

            int[] denominations = { 1000, 500, 200, 100, 50, 20, 10, 5, 1);
            foreach(int denomination in denominations)
            {
                int count = amount / denomination;
                Console.WriteLine($"{denomination} = {count}");
                amount %= denomination;
            }


        }
    }
}
