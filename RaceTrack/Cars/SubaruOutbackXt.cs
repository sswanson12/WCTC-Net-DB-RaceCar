using System;

namespace RaceTrack.RaceTrack.Cars;

public class SubaruOutbackXt : RaceCar
{
    public SubaruOutbackXt()
    {
        Name = "Subaru Outback XT";
        TopSpeed = 159;
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
        Console.WriteLine($"The {Name} cruises through the finish line in style at position {Position}!");
    }
}