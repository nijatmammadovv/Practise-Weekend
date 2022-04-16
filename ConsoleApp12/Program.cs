using System;
using ConsoleApp12.Models;
namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Mersedes", "Eclass",2004);           
            Bus bus = new Bus(50,2006);
            Vehicle[] vehicle = new Vehicle[0];
            Array.Resize(ref vehicle,vehicle.Length+1);
            vehicle[vehicle.Length - 1] = car;
            Array.Resize(ref vehicle, vehicle.Length + 1);
            vehicle[vehicle.Length - 1] = bus;
            foreach (var item in vehicle)
            {
                item.ShowInfo();
            }
        }
    }
}
