using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne.DaySix
{
    internal class ServiceA
    {
        int x = 0;
        public void DoTaskA()
        {
            Monitor.Enter(this);
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("Inside DoTaskA");
            Console.WriteLine("\t Thread id: "+ id);
            //int x = 0;
            try 
            { 
                for (int i = 0; i <= 5; i++)
                {
                    x+= i;
                    Console.WriteLine("\t ID=" + id + ": X=" + x + "i count =" + i);
                    Thread.Sleep(1000);
                }
            } 
            finally 
            { 
                Monitor.Exit(t1); 
            }
        }
    }
}
