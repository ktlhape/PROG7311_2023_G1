using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OOPPillars.Polymorphism
{
    internal class Sqaure : Shape 
    {
        public Sqaure(double side) : base(side,0)
        {
            
        }
        public override double CalcArea()
        {
            return width * width;
        }
        public override string PrintName()
        {
            return "Square";
        }
    }
}
