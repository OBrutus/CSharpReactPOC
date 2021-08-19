using System;
using Workouts.Threading;

namespace Workouts
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = new ThreadAbort();
            k.running();

            //Console.WriteLine("Hello World!");
            var obj = new Generics.Generics();
            obj.fn<int>();
            obj.fn<Program>();
            obj.fn<float>();
            obj.fn<double>();
            obj.fn<Single>();
        }
    }
}
