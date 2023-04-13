using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class Square : IShape
    {
        double side;
        public Square(double x)
        {
            this.side = x;
        }
        public double CalcArea()
        {
            return side * side;
        }

     
    }
}
