using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;

namespace CatML;

public class laser : Slider, IStyleable
{
    private string? _name;

    Type IStyleable.StyleKey => typeof(Slider);

    public static readonly DirectProperty<laser, string?> nameProperty =
        Slider.NameProperty.AddOwner<laser>(o => o.Name, (o, v) => o.Name = v);

    public static readonly StyledProperty<double> xProperty =
        Canvas.LeftProperty.AddOwner<laser>();

    public static readonly StyledProperty<double> yProperty =
        Canvas.TopProperty.AddOwner<laser>();

    public static readonly StyledProperty<double> minProperty =
        Slider.MinimumProperty.AddOwner<laser>();

    public static readonly StyledProperty<double> maxProperty =
        Slider.MaximumProperty.AddOwner<laser>();

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

    public double min
    {
        get => GetValue(minProperty);
        set => SetValue(minProperty, value);
    }

    public double max
    {
        get => GetValue(maxProperty);
        set => SetValue(maxProperty, value);
    }
}
