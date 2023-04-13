using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPillars.Interfaces
{
    internal class ShapeTester
    {
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle();
            IShape s = new Rectangle();
            Console.WriteLine("Area: " + rc.CalcArea(4,5));
        }
    }
}
