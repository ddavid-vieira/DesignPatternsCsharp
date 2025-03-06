namespace DesignPatternsCsharp.Creational.Builder;

// Concrete builder
public class CarBuilder : IBuilder
{
    private Car _car = new();

    public CarBuilder()
    {
        Reset();
    }
    public void Reset()
    {
        _car = new Car();
    }

    public void SetSeats(int number)
    {
        _car.Seats = number;
    }

    public void SetEngine(string engine)
    {
        _car.Engine = engine;
    }

    public void SetTripComputer(bool tripComputer)
    {
        _car.TripComputer = tripComputer;
    }

    public void SetGps(bool gps)
    {
       _car.Gps = gps;
    }
    
    public Car GetCar()
    {
        var car = _car;
        Reset();
        return car;
    }
}