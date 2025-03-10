using DesignPatternsCsharp.Creational.Builder;
using DesignPatternsCsharp.Creational.Singleton;

namespace DesignPatternsCsharp;

internal class Program
{
    private static void Main(string[] args)
    {
        //First instance
        var log1 = Logger.GetLogger;
        log1.Log("First log");
        //Second instance
        var log2 = Logger.GetLogger;
        log2.Log("Second log");
        
        // Builder pattern
        var carBuilder = new CarBuilder();
        var director = new Director(carBuilder);
        director.ConstructSportsCar();
        var sportsCar = carBuilder.GetCar();
        director.ConstructSuv();
        var suv = carBuilder.GetCar();
    }
}