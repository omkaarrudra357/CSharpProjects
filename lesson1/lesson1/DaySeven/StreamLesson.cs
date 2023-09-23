using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne.DaySeven
{
    internal class StreamLesson
    {
        //Char Streams
        public static void TestOne()
        {
            char ch;
            Console.WriteLine("press a key followed by enterL ");
            int x = Console.Read();
            ch = (char)x;
            Console.WriteLine("\n" + x + "your key is: " + ch);
        }

        public static void TestTwo()
        {
            char ch = ' ';
            Console.WriteLine(" press a key q to exit");
            while(ch != 'q') 
            {
                ch = (char) Console.Read();
                Console.WriteLine("your key is: " + ch);
            }
        }

        public static void TestThree()
        {
            Console.Out.WriteLine("enter a sentence");
            string? str = Console.ReadLine();   // string? means that it can have the possibility of containing null in it.
            Console.Out.WriteLine(" " + str);
        }

        public static void TestNullablrTypes()
        {
            int? x = 0;
            x = null;
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine(x.GetValueOrDefault());
            }
        }
    }
}
