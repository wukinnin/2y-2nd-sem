using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conOOPShapeGonzaga
{
    public class Shape
    {
        private string name;
        private int noSide;

        public Shape() { }

        public Shape(string name, int noSide)
        {
            this.name = name;
            this.noSide = noSide;
        }

        public string Name { get => name; set => name = value; }
        public int NoSide { get => noSide; set => noSide = value; }

        public override string ToString()
        {
            return "Name: " + this.name +
                "\nNo. of sides: " + this.noSide +
                "\nArea: " + this.ComputeArea();
        }

        public virtual double ComputeArea()
        {
            return 0.0;
        }
    }
}
