using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conCoffee
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // input 
            double bagPrice = 5.50;
            double largeBoxPrice = 3.00;
            double mediumBoxPrice = 2.50;
            double smallBoxPrice = 2.00;
            int largeBoxCapacity = 20;
            int mediumBoxCapacity = 10;
            int smallBoxCapacity = 5;

            Console.Write("Enter bags to order: ");
            int bagsOrdered = int.Parse(Console.ReadLine());

            // process
            int largeBoxesUsed = bagsOrdered / largeBoxCapacity;
            int mediumBoxesUsed = (bagsOrdered % largeBoxCapacity) / mediumBoxCapacity;
            int smallBoxesUsed = ((bagsOrdered % largeBoxCapacity) % mediumBoxCapacity) / smallBoxCapacity;
            if (((bagsOrdered % largeBoxCapacity) % mediumBoxCapacity) % smallBoxCapacity != 0)
            {
                smallBoxesUsed += 1;
            }
            double totalCost = (largeBoxesUsed * largeBoxPrice) + (mediumBoxesUsed * mediumBoxPrice) + (smallBoxesUsed * smallBoxPrice) + (bagsOrdered * bagPrice);

            // output
            Console.WriteLine("Number of Bags Ordered: " + bagsOrdered);
            Console.WriteLine("Boxes Used:");
            Console.WriteLine("Large - " + largeBoxesUsed);
            Console.WriteLine("Medium - " + mediumBoxesUsed);
            Console.WriteLine("Small - " + smallBoxesUsed);
            Console.WriteLine("Your total cost is: " + totalCost);
        }
    }
  
}
