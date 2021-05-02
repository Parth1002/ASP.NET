using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCopyConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new CarDetails object.
            CarDetails car1 = new CarDetails("Zen Estilo VXI", 15.7);

            // Create another new object, copying car1.
            CarDetails car2 = new CarDetails(car1);
            Console.WriteLine(car2.Details);
            Console.Write("\nPress ENTER to Quit..");
            Console.ReadLine();
        }
    }
    class CarDetails
    {
        private string ModelName;
        private double Mileage;
        // Copy constructor.
        public CarDetails(CarDetails MyCar)
        {
            ModelName = MyCar.ModelName;
            Mileage = MyCar.Mileage;
        }
        // Instance constructor.
        public CarDetails(string ModelName, double Mileage)
        {
            this.ModelName = ModelName;
            this.Mileage = Mileage;
        }
        public String Details
        {
            get
            {
                return ("Car " + ModelName + " has the Average of " + Mileage + "km/lit");
            }
        }
    }
}
