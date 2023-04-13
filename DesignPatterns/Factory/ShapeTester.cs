using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class ShapeTester
    {
        static void Main(string[] args)
        {
            ShapeFactory fc = new ShapeFactory();
            string option;
            Console.Write(fc.DisplayMenu());
            option = Console.ReadLine().ToUpper();
            //R
          
            IShape myShape = fc.GetShape(option);
            Console.WriteLine(fc.Print());



            Console.Read();
        }
    }
}
