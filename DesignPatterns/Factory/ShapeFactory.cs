using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class ShapeFactory
    {
        IShape myShape = null;
        public string DisplayMenu()
        {
            return "R - Rectangle, C - Circle, S - Square, T - Triangle: ";
        }
        public IShape GetShape(string option)
        {
          
            double length, width, radius;
            if (option.Equals("R"))
            {
                Console.Write("Enter length: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter width: ");
                width = Convert.ToDouble(Console.ReadLine());
                myShape = new Rectangle(length, width);
            }else if (option.Equals("C"))
            {
                Console.Write("Enter radius: ");
                radius = Convert.ToDouble(Console.ReadLine());
                myShape = new Circle(radius);
            }

            return myShape;
        }

        public string Print()
        {
            return $"Area of {myShape.GetType().Name} is {myShape.CalcArea()}";
        }
    }
}
