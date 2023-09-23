using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne.DayThree
{
    internal abstract class Book
    {
        public Book() 
        {
            Console.WriteLine("book constructor");
        }
        public abstract void OpenBook();
        

    }
    internal class Ebook : Book
    {
        public Ebook() { Console.WriteLine("Ebook constructor"); }
        public override void OpenBook()
        {
            Console.WriteLine("Ebook open");
        }
    }
    class BookTester
    {
        public static void Testone()
        {
            Book book = new Ebook();
            book.OpenBook();
        }
    }
}
