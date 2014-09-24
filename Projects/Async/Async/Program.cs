using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Stopwatch sw = Stopwatch.StartNew();
        //    int a = serial1();
        //    serial2();
        //    serial3();
        //    Console.WriteLine("After Thread" + sw.ElapsedMilliseconds / 1000);
        //    Console.ReadLine();
        //}

        //private static int serial1()
        //{
        //    Console.WriteLine("Hai 1");
        //    Thread.Sleep(5000);
        //    return 4;
        //}

        //private static void serial3()
        //{
        //    Console.WriteLine("Hai 3");
        //    Thread.Sleep(5000);

        //}

        //private static void serial2()
        //{
        //    Console.WriteLine("Hai 2");
        //    Thread.Sleep(4000);

        //}
        static void Main(String[] args)
        {
            Stopwatch a = Stopwatch.StartNew();
            Task<int> t1 = Task.Factory.StartNew<int>(task1);
            Task<int> t2 = Task.Factory.StartNew<int>(task2);
            Task<int> t3= Task.Factory.StartNew<int>(task3);
          //  Task.WaitAll(t1, t2, t3);
            Console.WriteLine(a.ElapsedMilliseconds / 1000.0);
            Console.ReadLine();
        }

        private static int task3()
        {
            Console.WriteLine("task3");
            return 1;
        }

        private static int task2()
        {
            Console.WriteLine("task2");
            return 2;
        }

        private static int task1()
        {
            Console.WriteLine("task1");
           return 3;
        }
    }
}
