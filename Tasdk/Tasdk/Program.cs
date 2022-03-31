using System;
using Tasdk.Models;
using System.Reflection;
namespace Tasdk
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Plane plane = new Plane();
            Bicycle bicycle = new Bicycle();

            car.CurrentOil = 5;
            car.DoorCount = 4;
            car.DrivePath = 10;
            car.DriveTime = 5;
            car.FuelType = "disel";
            car.HorsePower = 1000;
            car.TankSize = 599;
            car.ShowInfo(); 

        }
    }
}
