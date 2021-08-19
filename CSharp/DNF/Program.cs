using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DNF
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread runOp = new Thread(Operation);
            runOp.Start();
            Thread.Sleep(5000);
            runOp.Abort();
        }
        public static void Operation()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Running");
                Thread.Sleep(2000);
            }
        }
    }
}
