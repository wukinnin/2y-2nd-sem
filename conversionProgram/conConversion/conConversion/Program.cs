using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double centimetersPerInch = 2.54;
            double inchesPerFoot = 12;
            double feetPerYard = 3;

            // Input length in centimeters
            Console.Write("Enter length (in centimeters) >>> ");
            double lengthInCentimeters = Convert.ToDouble(Console.ReadLine());

            // Convert length to inches
            double lengthInInches = lengthInCentimeters / centimetersPerInch;

            // Convert inches to yards, feet, and remaining inches
            double totalInches = (int)(lengthInInches); // Rounding to the nearest inch
            double yards = (int)(totalInches / (inchesPerFoot * feetPerYard));
            double remainingFeet = (int)((totalInches % (inchesPerFoot * feetPerYard)) / inchesPerFoot);
            double remainingInches = totalInches % inchesPerFoot;

            // Output the result
            Console.WriteLine(yards + " yards, " + remainingFeet + " feet, " + remainingInches + " inches");
        }
    }
}
