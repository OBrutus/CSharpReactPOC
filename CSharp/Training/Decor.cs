using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    class Decor
    {
        public static void star(int times = 10, String pattern = "*")
        {
            for(int i = 0; i < times; i++)
                Console.Write(pattern);
        }
    }
}
