using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webcoreemptytemp
{
    public interface IDisplay
    {
        string disp();
    }

    public class Display : IDisplay
    {
        public string disp()
        {
            return "Displaying from Display Service class..";
        }
    }
}
