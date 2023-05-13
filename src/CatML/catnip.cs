using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;

namespace CatML;

public class catnip : ComboBox, IStyleable
{
    private string? _name;

    Type IStyleable.StyleKey => typeof(ComboBox);

    public static readonly DirectProperty<catnip, string?> nameProperty =
        ComboBox.NameProperty.AddOwner<catnip>(o => o.Name, (o, v) => o.Name = v);

    public static readonly StyledProperty<double> xProperty =
        Canvas.LeftProperty.AddOwner<catnip>();

    public static readonly StyledProperty<double> yProperty =
        Canvas.TopProperty.AddOwner<catnip>();

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

    protected override Control CreateContainerForItemOverride(object? item, int index, object? recycleKey)
    {
        return new option();
    }

    protected override bool NeedsContainerOverride(object? item, int index, out object? recycleKey)
    {
        return NeedsContainer<option>(item, out recycleKey);
    }
}
