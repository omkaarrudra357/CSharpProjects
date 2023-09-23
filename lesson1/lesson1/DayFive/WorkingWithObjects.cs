using LessonOne.DayThree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne.DayFive
{
    internal class WorkingWithObjects
    {
        public static void TestOne()
        {
            Object objectOne = new object();
            Console.WriteLine($"ToString: {objectOne.ToString()}");
            Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
            Type typeOne = objectOne.GetType();
            Console.WriteLine($"Type: {typeOne.FullName}");



            String stringData = "WorldCup 2023";
            Console.WriteLine($"ToString: {stringData.ToString()}");
            Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
            Type typeTwo = stringData.GetType();
            Console.WriteLine($"Type: {typeTwo.FullName}");
        }
        class Emp
        {
            public int ID;
            public string Name;
            public string Salary;
        }
        public static void TestTwo()
        {
            Emp empOne = new Emp();
            empOne.ID = 1001;
            empOne.Name = "Test";
            Emp empTwo = empOne;
            //Emp empTwo = new Emp();
            empTwo.ID = 1001;
            empTwo.Name = "Test";
            Emp empThree = new Emp();
            empThree.ID = 1001;
            empThree.Name = "Test";
            bool flag=(empOne.Equals( empTwo ));
            Console.WriteLine(flag);
            flag=empOne.Equals( empThree );
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode());
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());
        }
    }
}
