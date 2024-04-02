using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conOOPShapeGonzaga
{
    public class Square:Shape
    {
        private int side;

        public Square() { }

        public Square(string name, int noSide, int side)
        {
            base.Name = name;
            base.NoSide = noSide;
            this.side = side;
        }

        public int Side { get => side; set => side = value; }

        public override string ToString()
        {
            return "`\nName: " + base.Name +
                "\nNo. of sides: " + base.NoSide +
                "\nLength of 1 side: " + this.side+
                "\nArea: " + this.ComputeArea();
        }

        public override double ComputeArea()
        {
            return Math.Pow(side, 2);
        }
    }
}
