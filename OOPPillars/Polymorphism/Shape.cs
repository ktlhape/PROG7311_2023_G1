using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPillars.Polymorphism
{
    internal class Shape
    {
       protected double length;
       protected double width;
        public Shape()
        {}
        public Shape(double theWidth, double theLength)
        {
            this.width = theWidth;
            this.length = theLength;
        }
        public virtual double CalcArea()
        {
            return length * width;
        }
        public virtual string PrintName()
        {
            return "Shape";
        }
    }

}
