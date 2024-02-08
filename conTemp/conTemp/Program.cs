using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conTemp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double cel, fah, kel;

            // input
            Console.Write("Enter Value in Celsius: ");
            cel = double.Parse(Console.ReadLine());

            // process
            fah = cel*(9/5) + 32;
            kel = cel + 273.15;

            // output
            Console.WriteLine("Celsius: " + cel);
            Console.WriteLine("Fahrenheit: " + fah);
            Console.WriteLine("Kelvin: " + kel);


        }
    }
}
