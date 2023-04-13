using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPillars.Interfaces
{
    internal class Rectangle : IShape, IDrawable
    {
        public void ApplyColor()
        {
            Console.WriteLine("Applying blue color"); ;
        }

        public double CalcArea(double x, double y)
        {
            return x * y;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing the rectangle");
        }
    }
}
