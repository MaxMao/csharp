using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Object locker = new Object();

            Debug.WriteLine("main hello");

            var task = Task.Run(() =>
            {
                lock (locker)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Debug.WriteLine("sleep for the " + i + " times in child thread");
                    }
                }
                
                Debug.WriteLine("in child thread");
            });

            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Debug.WriteLine("sleep for the " + i + " times in main thread");
            }
            task.Wait();
            Debug.WriteLine("after waiting for the child thread");
        }
    }
}
