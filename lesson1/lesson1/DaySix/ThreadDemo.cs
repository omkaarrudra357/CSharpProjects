using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace LessonOne.DaySix
{
    internal class ThreadDemo
    {
        public static void DemoCurrentTH()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("threadId=" + id);
            Console.WriteLine("IsAlive=" + t1.IsAlive);
            Console.WriteLine("Priority=" + t1.Priority);
            Console.WriteLine("ThreadState=" +t1.ThreadState);
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new System.Globalization.CultureInfo("de=DE");
            Console.WriteLine("current Culture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }
        public static void DemoA()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTH ID:" + id);
            ServiceA a1 = new ServiceA();
            a1.DoTaskA();
        }
        public static void DemoB()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTH ID:" + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);//delegate
            t1.Start();
            a1.DoTaskA();
            Console.WriteLine("--------------------------End of demoB-----------------------");
        }

        public static void DemoB2()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTH ID:" + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);//delegate
            Console.WriteLine(t1.ManagedThreadId + "T1 State" + t1.ThreadState);
            t1.Start();
            Console.WriteLine(t1.ManagedThreadId + "State after start" + t1.ThreadState);
            Thread.Sleep(6000);
            Console.WriteLine(t1.ManagedThreadId + "T1 state after sleep" + t1.ThreadState);
            Console.WriteLine("--------------------------End of DemoB-----------------------");
        }
        public static void DemoC()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTH ID:" + id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskA;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();
            t1.Join(7000);
            if(t1.IsAlive) { t1.Abort(); }
            t2.Join(7000);
            if (t2.IsAlive) { t2.Abort(); }
            Console.WriteLine("--------------------------End of DemoC-----------------------");
        }
    }
}
