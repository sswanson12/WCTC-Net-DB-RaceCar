﻿using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class FordFocusRs : RaceCar
    {
        public FordFocusRs()
        {
            Name = "Ford Focus RS";
            TopSpeed = 165;
        }

        public override void StartEngine()
        {
            EngineRunning = true;
            Console.WriteLine($"The {Name} engine starts");
        }

        public override void StopEngine()
        {
            EngineRunning = false;
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} hauls through the finish line at position {Position}!");
        }
    }
}