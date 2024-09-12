using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public static int numberOfCars;//Added this for Static Keyword Exercise 2

        public List<Car> Cars { get; set; } = new List<Car>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
            numberOfCars++;//Added this for Static Keyword Exercise 2
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
