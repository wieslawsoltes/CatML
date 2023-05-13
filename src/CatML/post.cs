using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;

namespace CatML;

public class post : TextBox, IStyleable
{
    Type IStyleable.StyleKey => typeof(TextBox);

    public static readonly StyledProperty<string?> nameProperty =
        TextBox.TextProperty.AddOwner<post>();

    public static readonly StyledProperty<double> xProperty =
        Canvas.LeftProperty.AddOwner<post>();

    public static readonly StyledProperty<double> yProperty =
        Canvas.TopProperty.AddOwner<post>();

    public string? name
    {
        get => GetValue(nameProperty);
        set => SetValue(nameProperty, value);
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
