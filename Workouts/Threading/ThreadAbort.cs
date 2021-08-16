using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Workouts.Threading
{
    public class ThreadAbort
    {
        public void running()
        {
            Thread t = new Thread(Operation);
            t.Start();
            t.Abort();
        }
        void Operation()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("I am running");
                Thread.Sleep(2000);
            }
        }
    }
}
