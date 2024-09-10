using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLot
    {
        //Create a CarLot class
        //It should have at least one property: a List of cars
        //Instantiate a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console

        public List<Car> Cars { get; set; } = new List<Car>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void PrintCarDetails()
        {
            foreach (var car in Cars)
            {
                Console.WriteLine($"A {car.Year} {car.Make} {car.Model}");
            }
        }
    }
}
