using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldExample
{
    public class Car
    {
        public string make;
        public string model;
        int year;
        int month;
        public string VIN;
        public string exteriorColor;
        public string interiorColor;
        public Car(string make, string model, int year, int month, string vIN, string exteriorColor, string intereiorColor)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.month = month;
            this.VIN = vIN;
            this.exteriorColor = exteriorColor;
            this.interiorColor = intereiorColor;
        }
    }
}
