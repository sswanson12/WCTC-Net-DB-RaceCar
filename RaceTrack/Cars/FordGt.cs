using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class FordGt : RaceCar
    { 
        public FordGt()
        {
            Name = "Ford GT";
            TopSpeed = 100;
        }

        public override void StartEngine()
        {
            EngineRunning = true;
            Console.WriteLine($"The {Name} roars to life!");
        }

        public override void StopEngine()
        {
            EngineRunning = false;
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} at position {Position} flies through the finish line!");
        }
    }
}
