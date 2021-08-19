using System;
using System.Collections.Generic;
using System.Text;

namespace Workouts.AbstractClassWorkout
{
    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }

        void displayInfo();
        void acceptInfo(string Name, int Age);

    }
}
