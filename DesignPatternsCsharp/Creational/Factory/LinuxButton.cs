namespace DesignPatternsCsharp.Creational.Factory;

public class LinuxButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a Linux button.");
    }

    public void OnClick()
    {
        Console.WriteLine("Linux button clicked.");
    }
}