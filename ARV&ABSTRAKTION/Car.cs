using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARV_ABSTRAKTION
{
    public class Car
    {
        public string brand = "BMW";
        public string model = "X5";
        public string licensePlate = "AB12345";
        public int odometer = 0;
        public bool isEngineOn = false;

        public Car(string brand, string model, string licensePlate, int odometer, bool isEngineOn)
        {
            this.brand = brand;
            this.model = model;
            this.licensePlate = licensePlate;
            this.odometer = odometer;
            this.isEngineOn = isEngineOn;
        }
        public void StartEngine()
        {
            if (isEngineOn)
            {
                Console.WriteLine("Motoren er allerede tændt.");
            }
            else
            {
                isEngineOn = true;
                Console.WriteLine("Motoren er tændt.");
            }
        }

        public void StopEngine()
        {
            if (!isEngineOn)
            {
                Console.WriteLine("Motoren er allerede slukket.");
            }
            else
            {
                isEngineOn = false;
                Console.WriteLine("Motoren er slukket.");
            }
        }

        public void Drive(int distance)
        {
            if (isEngineOn)
            {
                odometer += distance;
                Console.WriteLine($"Bilen har kørt {distance} km. Den samlede afstand er nu {odometer} km.");
            }
            else
            {
                Console.WriteLine("Motoren skal være tændt for at køre.");
            }
        }
    }
}

