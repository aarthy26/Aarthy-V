using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreading_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("current executing thread is:" +Thread.CurrentThread.Name);
            Console.ReadLine();
        }
    }
}
