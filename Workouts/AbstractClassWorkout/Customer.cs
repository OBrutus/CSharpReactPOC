using System;
using System.Collections.Generic;
using System.Text;

namespace Workouts.AbstractClassWorkout
{
    class Customer : Person, IPerson
    {
        public Customer()
        {
            Name = "Null";
            Age = 0;
        }
        public Customer(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public override Role getRole()
        {
            return Role.Customer;
        }

    }
}
