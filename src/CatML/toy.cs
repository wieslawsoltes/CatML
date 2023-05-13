using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;

namespace CatML;

public class toy : Button, IStyleable
{
    private string? _name;

    Type IStyleable.StyleKey => typeof(Button);

    public static readonly DirectProperty<toy, string?> nameProperty =
        Button.NameProperty.AddOwner<toy>(o => o.Name, (o, v) => o.Name = v);

    public static readonly StyledProperty<double> xProperty =
        Canvas.LeftProperty.AddOwner<post>();

    public static readonly StyledProperty<double> yProperty =
        Canvas.TopProperty.AddOwner<post>();

    public string? name
    {
        get => _name;
        set => SetAndRaise(nameProperty, ref _name, value);
    }

    public static double Getx(AvaloniaObject element)
    {
        return element.GetValue(xProperty);
    }

    public static void Setx(AvaloniaObject element, double value)
    {
        element.SetValue(xProperty, value);
    }

    public static double Gety(AvaloniaObject element)
    {
        return element.GetValue(yProperty);
    }

    public static void Sety(AvaloniaObject element, double value)
    {
        element.SetValue(yProperty, value);
    }
}
