using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne.DayThree
{
    public enum City { Chennai, Bangalore, Hyderabad}
    public enum Designation { Manager, Admin, Developer}
    class Employee
    {
        public readonly int EId;
        public string EName = String.Empty;
        public City ECity;
        public Designation JobTittle;
        public Employee(int v1) { EId = v1; }
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public String ToString()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            Console.WriteLine("Details of employee are: ");
            String output=$"Details of employee are: {EId} {EName} {ECity} {JobTittle}";
            return output;
        }
    }
    class TestEmployee
    {
        public static void TestOne()
        {
            Employee e1 = new Employee(348);
            //e1.eid = 123;
            e1.EName = "John";
            e1.ECity = City.Bangalore; //ecity = "Chennai";
            e1.JobTittle = Designation.Developer;//edept = "Testing";
            String output = e1.ToString();
            Console.WriteLine(output);
        }
    }
}
