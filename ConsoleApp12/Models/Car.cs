using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12.Models
{
      class Car : Vehicle
     {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double MaxSpeed { get; set; }
        public override string Color { get; set ; }
        public override int Year { get; set ; }

        public Car(string brand,string model,int year):base(year)
        {
            Brand = brand;
            Model = model; 
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Brand ==> {Brand} Model ==>{Model} Maxspeed ==> {MaxSpeed} Color ==> {Color} Year ==>{Year}");
        }
    }
}
