namespace DesignPatternsCsharp.Creational.Singleton;

public sealed class Logger
{
    private static Logger? _instance;

    private Logger()
    {
    }

    private static Logger GetLogger => _instance ??= new Logger();
    private int CountLogs { get; set; }

    private void Log(string message)
    {
        Console.WriteLine($"[{++CountLogs}] {message}");
    }

    private static void Main()
    {
        //First instance
        var log1 = Logger.GetLogger;
        log1.Log("First log");
        //Second instance
        var log2 = Logger.GetLogger;
        log2.Log("Second log");
    }
}