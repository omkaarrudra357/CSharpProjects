using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne.DayThree
{
    internal abstract class Vehicle
    {
        public Vehicle() 
        {
            Console.WriteLine("vehicle constructor");
        }
        public void start()
        {
            Console.WriteLine("vehicle started");
        }
    }
    internal class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car constructor");
        }
    }
    class VehicleTester
    {
        public static void TestOne()
        {
            Vehicle tester = new Car();
            tester.start();
        }
    }
    

}
