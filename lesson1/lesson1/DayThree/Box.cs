using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne.DayThree
{
    internal class Box
    {
        public int Height;
        public int Length;
        public int Width;



        public Box(int x) //Constructor
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }

        public override string ToString()
        {
            return $"Height: {Height}, Length: {Length}, Width: {Width}";
        }

        internal class WoodenBox : Box 
        {
            public int Area;
            public WoodenBox():base(1)
            {
                Console.WriteLine("wooden box constructor"); 
            }
            public WoodenBox(int x):base(x)
            {
                Console.WriteLine("wooden box constructor");
            }
            public WoodenBox(int x,int y):base(x)
            {
                Console.WriteLine("wooden box constructor");
            }
            public void Move()
            {
                Console.WriteLine("wooden box shifted");
            }

        }
        internal class BoxTester
        {
            public static void TestTwo()
            {
                WoodenBox box = new WoodenBox();
                box.Height = 100;
                box.Length = 2000;
                box.Width = 50;
                box.Open();
                box.Close();
                box.ToString();
                String output = box.ToString();
                Console.WriteLine(output);
                box.Area = 300;
                box.Move();
            }
            public static void TestOne()
            {
                Box box = new Box(5);
                box.Height = 10;
                box.Length = 20;
                box.Width = 5;
                box.Open();
                box.Close();
                box.ToString();
                String output = box.ToString();
                Console.WriteLine(output);
                //box.Area = 300;
                //box.Move();
            }
            public static void TestThree()
            {
                Box box = new WoodenBox(5);
                box.Height = 101;
                box.Length = 203;
                box.Width = 56;
                box.Open();
                box.Close();
                box.ToString();
                String output = box.ToString();
                Console.WriteLine(output);
                //box.Area = 300;
                //box.Move();
            }
        }
    }
}
