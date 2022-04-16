using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12.Models
{
    class Bus:Vehicle
    {
        public int PassengerCount { get; set; }
        public override string Color { get ; set ; }
        public override int Year { get ; set ; }

        public Bus(int passengerCount,int year):base(year)
        {
            PassengerCount = passengerCount;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"PassengerCount == {PassengerCount} Color ==> {Color} Year ==> {Year}");
        }
    }
}
