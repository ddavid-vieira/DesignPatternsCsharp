namespace DesignPatternsCsharp.Creational.Builder;

// (Optional) The Director is only responsible for executing the building steps in a particular sequence.
public class Director
{
    private readonly IBuilder _builder;

    public Director(IBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructSportsCar()
    {
        _builder.Reset();
        _builder.SetSeats(2);
        _builder.SetEngine("V8");
        _builder.SetTripComputer(true);
        _builder.SetGps(true);
    }

    public void ConstructSuv()
    {
        _builder.Reset();
        _builder.SetSeats(4);
        _builder.SetEngine("V6");
        _builder.SetTripComputer(true);
        _builder.SetGps(true);
    }
}