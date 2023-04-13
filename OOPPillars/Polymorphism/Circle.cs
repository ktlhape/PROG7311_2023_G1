using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPillars.Polymorphism
{
    internal class Circle : Shape
    {
        public Circle(double radius): base(radius, 0)
        {
            
        }

        public override double CalcArea()
        {
            return Math.PI * Math.Pow(width,2);
        }
    }
}
