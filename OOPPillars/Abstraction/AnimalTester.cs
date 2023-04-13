using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPillars.Abstraction
{
    internal class AnimalTester
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.MakeSound();
            Dog g = new Dog();
            g.MakeSound();

        }
    }
}
