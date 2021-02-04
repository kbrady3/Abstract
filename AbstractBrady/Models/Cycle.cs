using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractBrady.Models
{
    public abstract class Cycle
    {
        public int NumberOfTires { get; set; }
        public int NumberOfFlats { get; set; }

        public Cycle() { }

        public Cycle(int numberOfTires, int numberOfFlats)
        {
            NumberOfTires = numberOfTires;
            NumberOfFlats = numberOfFlats;
        }

        public abstract string Ride();
        public abstract string Stop();

        public string CycleDetails()
        {
            return "Number of tires: " + NumberOfTires + ", Number of flats: " + NumberOfFlats;
        }
    }
}
