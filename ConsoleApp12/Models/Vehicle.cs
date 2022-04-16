using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12.Models
{
    abstract class Vehicle
    {
       public  abstract string Color  { get; set; }
        public abstract int Year  { get; set; }
        public abstract void ShowInfo();
        public Vehicle(int year)
        {
            Year = year;
        }

    }
}
