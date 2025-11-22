using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Race
{
    class Program
    {
        static public void PrintModel(Car car)
        {
            Console.WriteLine(car.GetModel());
        }
        static public void LadaVSMers(List<Car> cars)
        {
            int time = 0;
            int finish = 248;
            while (true)
            {
                foreach (Car car in cars)
                {
                    int SpaceSpeed = car.GetSpeed() / 50;
                    for (int i = 0; i < SpaceSpeed;)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(car.GetModel());
                    Console.WriteLine();
                    if (SpaceSpeed < finish)
                    {
                        Console.WriteLine("Победитель - " + car.GetModel());
                    }

                  
                }
                time++;
                Thread.Sleep(1000);
                    Console.Clear();
            }
        }
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.SetModel("Лада");
            Console.WriteLine(car1.GetModel());
            car1.SetSpeed(150);
            Car car2 = new Car();
            car2.SetModel("Мерседес");
            Console.WriteLine(car1.GetModel());
            car2.SetSpeed(500);
            PrintModel(car2);
            List<Car> Cars = new List<Car>();
            Cars.Add(car1);
            Cars.Add(car2);
            LadaVSMers(Cars);
        } 
    }
}
