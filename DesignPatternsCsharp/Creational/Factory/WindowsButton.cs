namespace DesignPatternsCsharp.Creational.Factory;

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a Windows button.");
    }

    public void OnClick()
    {
        Console.WriteLine("Windows button clicked.");
    }
}