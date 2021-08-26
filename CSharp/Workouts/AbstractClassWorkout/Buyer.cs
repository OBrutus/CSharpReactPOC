using System;
using System.Collections.Generic;
using System.Text;

namespace Workouts.AbstractClassWorkout
{
    class Buyer : Person, IPerson
    {
        public override Role getRole()
        {
            return Role.Buyer;
        }
    }
}
