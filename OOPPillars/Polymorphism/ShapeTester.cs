using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPillars.Polymorphism
{
    internal class ShapeTester
    {
        static void Main(string[] args)
        {
            Shape s = new Shape(4, 5);
            Console.WriteLine("Area: " + s.CalcArea());
            Rectangle rc = new Rectangle();
            Console.WriteLine(rc.PrintName());

            Shape sq = new Sqaure(5);
            Console.WriteLine("Area: " + sq.CalcArea());
        }
    }
}
