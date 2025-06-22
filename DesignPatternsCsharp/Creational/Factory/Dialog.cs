namespace DesignPatternsCsharp.Creational.Factory;

public abstract class Dialog
{
    protected abstract IButton CreateButton();

    public void Render()
    {
        var button = CreateButton();
        button.OnClick();
        button.Render();
    }
}

public class WindowsButtonCreator : Dialog
{
    protected override IButton CreateButton()
    {
        return new WindowsButton();
    }
}

public class LinuxButtonCreator : Dialog
{
    protected override IButton CreateButton()
    {
        return new LinuxButton();
    }
}