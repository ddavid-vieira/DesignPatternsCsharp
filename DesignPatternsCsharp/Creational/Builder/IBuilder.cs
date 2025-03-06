namespace DesignPatternsCsharp.Creational.Builder;

// The builder interface specifies methods for creating the different parts of the product objects.
public interface IBuilder
{
    void Reset();
    void SetSeats(int number);
    void SetEngine(string engine);
    void SetTripComputer(bool tripComputer);
    void SetGps(bool gps);
}