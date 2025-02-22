using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualConsoleApp.Models
{
    class Car
    {
        // di default le proprietà sono private
        public string Make = "";
        public string Model = string.Empty;
        public int Year;

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public void Start()
        {
            Console.WriteLine($"We have created car: {Make} {Model} of {Year} year");
        }
    }
}

