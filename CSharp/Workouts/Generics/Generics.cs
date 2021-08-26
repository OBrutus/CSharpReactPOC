using System;
using System.Collections.Generic;
using System.Text;

namespace Workouts.Generics
{
    public class Generics
    {
        public void fn<T>()
        {
            Console.WriteLine(typeof(T));
        }
    }
}
