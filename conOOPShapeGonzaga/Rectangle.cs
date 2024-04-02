using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conOOPShapeGonzaga
{
    public class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle()
        {
        }

        public Rectangle(string name, int noSide, int length, int width)
        {
            base.Name = name;
            base.NoSide = noSide;
            this.length = length;
            this.width = width;
        }

        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }

        public override string ToString()
        {
            return "\nName: " + base.Name +
                "\nNo. of sides: " + base.NoSide +
                "\nLength: " + this.length +
                 "\nWidth: " + this.width+
                 "\nArea: " + this.ComputeArea();
        }
        public override double ComputeArea()
        {
            return this.length * this.width;
        }

    }
}
