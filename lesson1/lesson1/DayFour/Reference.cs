using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne.DayFour
{
    internal class Reference
    {
        public  static void DoTask(int x) 
        {
            int i = x+2000;
            x=i;
            Console.WriteLine(x);
        }
        public static void DoTaskA(ref int x)
        {
            int i = x+2000;
            x=i;
            Console.WriteLine(x);
        }

        public class ReferenceTest
        {
            public static void TestOne()
            {
                int v1 = 1000;
                Console.WriteLine($"V1:{ v1}");
                DoTask(v1);
                Console.WriteLine($"V1:{ v1}");
                DoTaskA(ref v1);
                Console.WriteLine($"V1:{ v1}");
            }
        }
    }
}
