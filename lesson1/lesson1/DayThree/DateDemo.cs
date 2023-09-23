using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LessonOne.DayThree
{
    internal class DateDemo
    {
        public static void FirstMethod()
        {
            System.Console.WriteLine( );
            DateTime d1 = new DateTime(2018, 04, 10);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToShortDateString());
        }
        public static void SecondMethod()
        {
            Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);
            int year = d1.Year;
            Console.WriteLine("Year OF Dob " + year);
            int month = d1.Month;
            Console.WriteLine("Month OF Dob " + month);
            int day = d1.Day;
            Console.WriteLine("Day OF Dob " + day);
            DateTime d2 = d1.AddMonths(10);
            Console.WriteLine("AddMonths(10) " + d2.ToShortDateString());
            DateTime d3 = d1.AddDays(5);
            Console.WriteLine("AddDays(5) " + d3.ToShortDateString());
            DateTime d4 = d1.AddYears(58);
            Console.WriteLine("AddYears(58) " + d4.ToShortDateString());
            DateTime d5 = d1.AddYears(-5);
            Console.WriteLine("AddYears(-5) " + d5.ToShortDateString());
        }
        public static void ThirdMethod()
        {
            Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
            String strdob = String.Empty;
            Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);
            DateTime d2 = DateTime.Now;
            TimeSpan ts = d2.Subtract(d1);
            DateTime age = new DateTime(ts.Ticks);
            Console.WriteLine("Age in date" + age.ToShortDateString());    
        }
        public static void FourthMethod()
        {
            // Prompt the user for their date of birth
            Console.WriteLine("Enter your date of birth (YYYY-MM-DD):");
            string dobString = String.Empty;
            try
            {
                dobString = Console.ReadLine();
                if (dobString == null)
                {
                    Console.WriteLine("Date Of Birth is NULL!!!");
                    return;
                }
                // Parse the date of birth
                DateTime dob = DateTime.Parse(dobString);



                // Calculate the age
                DateTime now = DateTime.Now;
                int ageYears = now.Year - dob.Year;
                if (now < dob.AddYears(ageYears))
                {
                    ageYears--;
                }
                int ageMonths = now.Month - dob.Month;
                if (now < dob.AddMonths(ageMonths).AddDays(now.Day - dob.Day))
                {
                    ageMonths--;
                }
                int ageDays = now.Day - dob.Day;
                if (now.Day < dob.Day)
                {
                    ageDays += DateTime.DaysInMonth(now.Year, now.Month);
                }
                // Print the age
                Console.WriteLine(
                    $"You are {ageYears} years, {ageMonths} months, and {ageDays} days old."
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void FifthMethod()
        {
            Console.Write("Enter your date of birth (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dob))
            {
                int age = DateTime.Now.Year - dob.Year;
                if (DateTime.Now.Month < dob.Month || (DateTime.Now.Month == dob.Month && DateTime.Now.Day < dob.Day))
                {
                    age--;
                }

                Console.WriteLine($"Your age is: {age} years.");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please use yyyy-MM-dd format.");
            }
        }
        public static void SixthMethod()
        {
            Console.Write("Enter your date of birth (yyyy-MM-dd): ");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);
            DateTime d2 = DateTime.Now;
            TimeSpan d3 = d2 - d1;
            Console.WriteLine(d3);
            
        }
        public static void FindRetirementDate()
        {
            Console.Write("Enter your date of birth (yyyy-MM-dd): ");
            string strdob = String.Empty;
            try
            {
                strdob = $"{Console.ReadLine()}";
                DateTime dob = DateTime.Parse(strdob);
                DateTime nextMonthFirstDay = new DateTime(dob.Year + 60, dob.Month + 1, 1);
                DateTime retirementDate = nextMonthFirstDay.AddDays(-1);
                Console.WriteLine("your retirement date is  " + retirementDate.ToShortDateString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
            
        }


    }
}
