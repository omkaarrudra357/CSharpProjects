using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne.DaySeven
{
    internal class ThreadTask
    {
        public static void TaskMethodA() 
        {
            Console.WriteLine("running task");
             Console.WriteLine($"task id: {Task.CurrentId} ");
        }

        public static void TestOne()
        {
            int id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"CurrentThreadID:{id}");
            //TaskFactory tf = new TaskFactory();
            //Task t1 = tf.StartNew(ClassA.TaskMethodA);         



            //Task t2 = Task.Factory.StartNew(ClassA.TaskMethodA);



            Task t3 = new Task(ThreadTask.TaskMethodA);
            t3.Start();
            Task t4 = new Task(ThreadTask.TaskMethodA);
            t4.Start();
        }

        public static void ContinueTask()
        {
            Task t1 = new Task(ThreadTask.TaskMethodA);
            Task t2 = t1.ContinueWith(ThreadTask.TaskMethodB);
            Task t3 = t1.ContinueWith(ThreadTask.TaskMethodC);
            Task t4 = t2.ContinueWith(ThreadTask.TaskMethodB1);
            t1.Start();
            Console.WriteLine("Bye from ContinueTask");
        }

        public static void TaskMethodB(Task t)
        {
            Console.Write("running TaskB");
            Console.WriteLine($" After task {t.Id} ");
            Thread.Sleep(15000);
            Console.WriteLine($"taskB id {Task.CurrentId} Completed");
        }
        public static void TaskMethodC(Task t)
        {
            Console.Write("running TaskC");
            Console.WriteLine(" After task {0} ", t.Id);
            Thread.Sleep(1000);
            Console.WriteLine("taskC id {0} Completed", Task.CurrentId);
        }
        public static void TaskMethodB1(Task t)
        {
            Console.Write("running TaskB1");
            Console.WriteLine(" After task {0} ", t.Id);
            Console.WriteLine("taskB1 id {0} Completed", Task.CurrentId);
        }

        public static void ParentTask()
        {
            Console.WriteLine("Inside parentTask ");
            Console.WriteLine($"ParentTask id {Task.CurrentId}");
            var child = new Task(ChildTask, TaskCreationOptions.AttachedToParent);
            child.Start();
            Console.WriteLine("parent has started child");
            Thread.Sleep(1000);
        }
        public static void ChildTask()
        {
            Console.WriteLine("child started");
            Console.WriteLine($"childTask id {Task.CurrentId}");
            Thread.Sleep(10000);
            Console.WriteLine("child finished");
        }

        public static void ParentAndChild()
        {
            var parent = new Task(ThreadTask.ParentTask);
            Console.WriteLine("ParentStatus1: " + parent.Status);
            parent.Start();
            Console.WriteLine("ParentStatus2: " + parent.Status);
            #region A
            Thread.Sleep(1000);
            Console.WriteLine("ParentStatus: " + parent.Status);
            Thread.Sleep(1000);
            Console.WriteLine("ParentStatus: " + parent.Status);
            #endregion
            Console.WriteLine("Test Completed");
        }
        static int GenerateNumbers(CancellationToken ct)
        {
            int i;
            for (i = 0; i < 1000; i++)
            {
                Console.WriteLine("Method1 - Number: {0}", i);
                Thread.Sleep(1000);
                // poll the IsCancellationRequested property
                // to check if cancellation was requested
                if (ct.IsCancellationRequested)
                {
                    break;
                }
            }
            return i;
        }
        // Notify when task is cancelled
        static void CancelNotification()
        {
            Console.WriteLine("Cancellation request made!!");
        }



        public static void TestCancelToken()

        {

            Console.WriteLine("Press 1 to cancel task");

            var cTokenSource = new CancellationTokenSource();

            var cToken = cTokenSource.Token;

            var t1 = Task<int>.Factory.StartNew(

                () => ThreadTask.GenerateNumbers(cToken), cToken);

            // to register a delegate for a callback when a 

            // cancellation request is made

            cToken.Register(ThreadTask.CancelNotification);

            // If user presses 1, request cancellation.

            if (Console.ReadKey().KeyChar == '1')

            {

                cTokenSource.Cancel();

            }

        }
    }
}
