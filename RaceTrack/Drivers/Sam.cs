using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers;

public class Sam : Driver
{
    public Sam(RaceCar car) : base(car)
    {
        Name = "Sam";
        SkillLevel = 20;
    }

    public override void Drive()
    {
        Car.Accelerate(SkillLevel);
    }
}