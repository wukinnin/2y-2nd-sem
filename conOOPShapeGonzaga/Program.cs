using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace conOOPShapeGonzaga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape sh = new Shape("Shape", 0);
            Console.WriteLine(sh);

            sh = new Square("Square", 4, 3);
            Console.WriteLine(sh);

            sh = new Rectangle("Rectangle", 4, 4, 3);
            Console.WriteLine(sh);
        }
    }
}

