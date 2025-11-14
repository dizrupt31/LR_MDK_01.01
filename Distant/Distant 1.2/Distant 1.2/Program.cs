using System;
using System.Collections.Generic;
using DataStructure; 
using Functions;     

namespace MainProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> allCars = new List<Car>(); 
            Random random = new Random();         

            Console.WriteLine("Создание 100 тестовых автомобилей");
            for (int i = 1; i <= 100; i++)
            {
                Car newCar = new Car();
                newCar.Brand = "Car Brand " + i;
                newCar.Year = random.Next(2010, 2025); 
                newCar.Power = random.Next(90, 601);  

                allCars.Add(newCar);
            }

            Console.WriteLine("100 автомобилей успешно созданы.");
            Console.WriteLine("-------------------------------------------");
            List<Car> topCars = CarFinder.FindTop10Cars(allCars);

            Console.WriteLine("\n ТОП-10 АВТОМОБИЛЕЙ ПО МОЩНОСТИ");

            int rank = 1; 
            foreach (Car car in topCars)
            {
                Console.WriteLine($"{rank}. {car.Brand,-15} (Год: {car.Year}) - Мощность: {car.Power} л.с.");
                rank++;
            }
            Console.WriteLine("-----------------------------------------------");

            Console.ReadKey();
        }
    }
}