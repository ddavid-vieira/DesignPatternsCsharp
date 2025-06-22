namespace DesignPatternsCsharp.Creational.Factory;

public class Application
{
    public Dialog Dialog { get; set; }


    public Application()
    {
        Initialize("Windows");
    }

    private void Initialize(string osType)
    {
        Dialog = osType switch
        {
            "Windows" => Dialog = new WindowsButtonCreator(),
            "Linux" => Dialog = new LinuxButtonCreator(),
            _ => throw new NotSupportedException($"OS type '{osType}' is not supported.")
        };
    }
}