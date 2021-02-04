using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractBrady.Models
{
    public class Bicycle : Cycle
    {
        public Bicycle(int numberOfTires, int numberOfFlats) : base(numberOfTires, numberOfFlats)
        {

        }

        public override string Ride()
        {
            return "We're a-movin'!";
        }

        public override string Stop()
        {
            return "You stopped moving.";
        }
    }
}
