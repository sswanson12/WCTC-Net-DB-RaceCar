using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class CarrollShelby : Driver
    {
        public CarrollShelby(RaceCar car) : base(car)
        {
            Name = "Carroll Shelby";
            SkillLevel = 25; //compared to this random guy Antonio
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}