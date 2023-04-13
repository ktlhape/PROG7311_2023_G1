using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPillars.Encapsulation
{
    internal class Car
    {
        string name;
        int fuel;
        int speed;
        public Car(string theName)
        {
            name = theName;
            speed = 0;
            fuel = 100;
        }

        public void StartEngine()
        {
            Console.WriteLine("Engine started");
            TurnMotor();
        }

       private void BurnFuel()
        {
            fuel -= 5;
        }

        private void TurnMotor()
        {
            BurnFuel();
        }

        public void Drive()
        {
            Console.WriteLine("Driving");
            fuel--;
        }
       public void SpeedUp()
        {
            fuel--;
            speed += 15;
        }

        public void Dashboard()
        {
            Console.WriteLine("Car: " + name);
            Console.WriteLine($"Driving at {speed}KM/H");
            Console.WriteLine($"Fuel: {fuel}");
        }


	}
}
