using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARV_ABSTRAKTION
{
    internal class ElectricCar : Car
    {
        public double batteryCapacity;
        public double batteryLevel;
        public double KmPerKWh;
     

        public ElectricCar(string brand, string model, string licensePlate, int odometer, bool isEngineOn, double batteryCapacity, double batteryLevel, double KmPerKWh) : base(brand, model, licensePlate, odometer, isEngineOn)
        {
            this.batteryCapacity = batteryCapacity;
            this.batteryLevel = batteryLevel;
            this.KmPerKWh = KmPerKWh;
        
        }
        public void ChargeBattery(double amount)
        {
            if (amount < 0) { Console.WriteLine("Mængden skal værempositiv"); }
            else if (batteryLevel + amount > batteryCapacity)
            { Console.WriteLine("Batteriet kan ikke oplades mere end det kapacitet"); }
            else { batteryLevel += amount; Console.WriteLine($"Batteriet er blevet øget med {amount} KWh. Hermed nuværende batteriniveau {batteryLevel} KWh"); }
        }
        //ctr k + ctrl c
        //fjerne ctrl k + ctrl u
        //public double GetBatteryLevel(double batteryLevel, double distance)
        //{
        //double batteryLevel -distance
        //    return batteryCapacity;

        }
}
