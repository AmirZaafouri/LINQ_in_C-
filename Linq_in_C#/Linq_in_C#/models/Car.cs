using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_.POCO
{
    public class Car
    {

        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        // Default Constructor
        public Car() { }

        // All-Args Constructor
        public Car(int id, string make, string model, string color, int year, double price)
        {
            Id = id;
            Make = make;
            Model = model;
            Color = color;
            Year = year;
            Price = price;
        }

        // Overriding ToString() method
        public override string ToString()
        {
            return $"Car[Id={Id}, Make={Make}, Model={Model}, Color={Color}, Year={Year}, Price={Price}]";
        }
    }
}
