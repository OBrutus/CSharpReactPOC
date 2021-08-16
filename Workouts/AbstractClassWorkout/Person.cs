using System;
using System.Collections.Generic;
using System.Text;

namespace Workouts.AbstractClassWorkout
{
    abstract class Person : IPerson
    {
        public string Name { get => Name; set => Name = value; }
        public int Age { 
            get => Age; 
            set { if (Age < 12)
                    throw new Exception();
                    Age = value; 
            }  
        }

        public void acceptInfo(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Name = {Name} \t Age = {Age}");
        }

        public abstract Role getRole();

    }
}
