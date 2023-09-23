using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne.DayFour
{
    internal class CollectioDemo
    {
        public static void TestArrayList()
        {
            ArrayList alist = new ArrayList();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 0
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
                alist.Add(r1.Next(10));
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 16

            for (int j = 0; j < 10; j++) alist.Add(j);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 32



            for (int i = 0; i < alist.Count; i++)
            {
                Console.Write(alist[i] + ",");
                if (i > 0 && i % 10 == 0) Console.WriteLine();
            }
            foreach (int x in alist)
            {
                Console.Write(x + " ");
            }
        }
    }
}
