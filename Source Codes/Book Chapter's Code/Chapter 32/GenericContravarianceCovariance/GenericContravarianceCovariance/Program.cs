using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericContravarianceCovariance
{
    class Vehicle { }
    class Car : Vehicle { }
    class Program
    {
        delegate T Func1<out T>();
        delegate void Action1<in T>(T a);
        static void Main(string[] args)
        {
            Func1<Car> c = () => new Car();
            Func1<Vehicle> vehi = c;

            Action1<Vehicle> v2 = (vehi2) => { Console.WriteLine(vehi2); };
            Action1<Car> c1 = v2;

            Console.WriteLine(vehi());
            c1(new Car());
        }
    }
}
