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

           

            car.ShowInfo();
            Console.WriteLine("----------");
            plane.ShowInfo();
            Console.WriteLine("----------");
            bicycle.ShowInfo();

        }
    }
}
