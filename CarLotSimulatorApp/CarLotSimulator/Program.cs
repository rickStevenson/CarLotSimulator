using System;
using System.Runtime.ConstrainedExecution;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

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
        }
    }
}
