using System;
using System.Runtime.ConstrainedExecution;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();

            Console.WriteLine("Welcome to Fast Eddie's Car Lot!");
            Console.WriteLine("________________________________");

            var car1 = new Car()
            {
                Year = 2020,
                Make = "Chevy",
                Model = "Camero",
                EngineNoise = "rev",
                HonkNoise = "mild",
                IsDriveable = true
            };
            Console.WriteLine($"This is a {car1.Year} {car1.Make} {car1.Model}");
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            Console.WriteLine("");

            var car2 = new Car();

            car2.Year = 2022;
            car2.Make = "Ford";
            car2.Model = "Mustang";
            car2.EngineNoise = "purr";
            car2.HonkNoise = "loud";
            car2.IsDriveable = true;

            Console.WriteLine($"This is a {car2.Year} {car2.Make} {car2.Model}");
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            Console.WriteLine("");

            var car3 = new Car(2024, "Toyota", "4 Runner", "purr", "mild", true);

            Console.WriteLine($"This is a {car3.Year} {car3.Make} {car3.Model}");
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            carLot.AddCar(car1);
            carLot.AddCar(car2);
            carLot.AddCar(car3);

            Console.WriteLine("");
            Console.WriteLine("__________________");
            Console.WriteLine("You viewed the following cars:");

            carLot.PrintCarDetails();

            Console.WriteLine("");
            Console.WriteLine($"Cars viewed = {CarLot.numberOfCars}");//Added this for Static Keyword Exercise 2
        }
    }
}
