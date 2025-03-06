namespace DesignPatternsCsharp.Creational.Singleton;

//Singleton pattern ensures that a class has only one instance and provides a global point of access to it.
public sealed class Logger
{
    // Static variable that holds the instance of the class
    private static Logger? _instance;

    // Private constructor so that no instance can be created
    private Logger()
    {
    }

    // Public static method that returns the instance of the class, this is the global access point for outer world to get the instance of the singleton class
    public static Logger GetLogger => _instance ??= new Logger();
    private int CountLogs { get; set; }

    // Public method that logs the message
    public void Log(string message)
    {
        Console.WriteLine($"[{++CountLogs}] {message}");
    }
}