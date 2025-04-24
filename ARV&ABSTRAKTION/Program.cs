namespace ARV_ABSTRAKTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", "X5", "AB12345", 0, false);
            car.StartEngine();
            car.Drive(100);
            car.StopEngine();
            Console.WriteLine($"Bilmærke {car.brand} model {car.model} nummerplade {car.licensePlate} kilometerstand {car.odometer}");
            Console.ReadLine();
            ElectricCar car1 = new ElectricCar("Hyundai", "Ioniq", "QT12345", 0, true, 5000, 1000, 30, 100);
            car1.StartEngine();
            car1.Drive(100);
            car1.StopEngine();
            Console.WriteLine($"Bilmærke {car1.brand}, model {car1.model}, nummerplade {car1.licensePlate}, kilometerstand {car1.odometer}, batterikapasitet{5000}, batteritilstand {car1.batteryLevel}, Kmperkwh {car1.KmPerKWh}");

            Console.ReadKey();

        }
    }
}
