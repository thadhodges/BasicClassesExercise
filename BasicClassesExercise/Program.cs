using System;
using System.Collections.Generic;

namespace BasicClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            car1.Make = "Chevy";
            car1.Model = "Nova";
            car1.Year = 1974;

            var car2 = new Car();
            car2.Make = "Toyota";
            car2.Model = "Sienna";
            car2.Year = 2015;

            var car3 = new Car();
            car3.Make = "Kia";
            car3.Model = "Forza";
            car3.Year = 2018;

            var carList = new List<Car>();
            carList.Add(car1);
            carList.Add(car2);
            carList.Add(car3);

            foreach(var car in carList)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }

        }
    }
}
