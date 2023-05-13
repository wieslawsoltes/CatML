using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Metadata;
using Avalonia.Styling;

namespace CatML;

public class litter : Label, IStyleable
{
    Type IStyleable.StyleKey => typeof(Label);

    public static readonly StyledProperty<object?> nameProperty =
        ContentControl.ContentProperty.AddOwner<litter>();

    public static readonly StyledProperty<double> xProperty =
        Canvas.LeftProperty.AddOwner<litter>();

    public static readonly StyledProperty<double> yProperty =
        Canvas.TopProperty.AddOwner<litter>();

    [Content]
    [DependsOn(nameof(ContentTemplate))]
    public object? name
    {
        get { return GetValue(nameProperty); }
        set { SetValue(nameProperty, value); }
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
