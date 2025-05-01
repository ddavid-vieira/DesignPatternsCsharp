namespace DesignPatternsCsharp.Creational.Builder;

// (Optional) The Director is only responsible for executing the building steps in a particular sequence.
public class Director(IBuilder builder)
{
    public void ConstructSportsCar()
    {
        builder.Reset();
        builder.SetSeats(2);
        builder.SetEngine("V8");
        builder.SetTripComputer(true);
        builder.SetGps(true);
    }

    public void ConstructSuv()
    {
        builder.Reset();
        builder.SetSeats(4);
        builder.SetEngine("V6");
        builder.SetTripComputer(true);
        builder.SetGps(true);
    }
}