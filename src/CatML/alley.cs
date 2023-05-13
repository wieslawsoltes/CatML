using Avalonia;

namespace CatML;

public class alley : Application
{
    private string? _name;

    public static readonly DirectProperty<alley, string?> nameProperty =
        Application.NameProperty.AddOwner<alley>(o => o.name, (o, v) => o.name = v);

    public string? name
    {
        get => _name;
        set => SetAndRaise(nameProperty, ref _name, value);
    }
}
