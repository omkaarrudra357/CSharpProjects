using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LessonOne.ExamQues.Car;

//Create a class called Car.
//The Car has a RegistrationNo, Model, FuelType, Wheels[4],
//and 1 Engine.

//The FuelType must be an Enum
//Wheel, and Engine must be INNER Class.

namespace LessonOne.ExamQues
{
    internal class Car
    {
        public string RegNo { get; set; }
        public string Model { get; set; }
        public FuelType FuelType { get; set; }
        public Wheel[] Wheels { get; set; }
        public Engine CEngine { get; set; }

        public Car(string regNo, string model, FuelType fuelType)
        {
            RegNo = regNo;
            Model = model;
            FuelType = fuelType;  
        }

       
        public class Wheel
        {
            public string Type { get; set; }
        }
        public class Engine
        {
            public double Horsepower { get; set; }
        }
        public Car()
        {
            Wheels = new Wheel[4];
            CEngine = new Engine();
        }
    }

    public enum FuelType
    {
        CNG,
        Petrol,
        Diesel,
        Electric,
    }

    public class Testing
    {
        public static void TestOne()
        {

            Car myCar = new Car("11111", "XUV", FuelType.Petrol);

            myCar.Wheels[0] = new Car.Wheel {Type = "Alloy" };
            myCar.Wheels[0] = new Car.Wheel {Type = "Alloy" };
            myCar.Wheels[0] = new Car.Wheel {Type = "Alloy" };
            myCar.Wheels[0] = new Car.Wheel {Type = "Alloy" };

            myCar.CEngine.Horsepower = 300.0;

            Console.WriteLine($"Car Details: {myCar.Model}, {myCar.RegNo}, {myCar.FuelType}");
            Console.WriteLine($"Engine Details: {myCar.CEngine.Horsepower} HP");
            Console.WriteLine("Wheel Details:");
            foreach (var wheel in myCar.Wheels)
            {
                Console.WriteLine($"{wheel.Type}");
            }

        }
    }

   
}

