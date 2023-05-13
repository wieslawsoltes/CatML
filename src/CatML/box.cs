using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;

namespace CatML;

public class box : Window, IStyleable
{
    Type IStyleable.StyleKey => typeof(Window);

    public static readonly DirectProperty<box, string?> nameProperty =
        Window.NameProperty.AddOwner<box>(o => o.Name, (o, v) => o.Name = v);

    public static readonly StyledProperty<double> widthProperty =
        Window.WidthProperty.AddOwner<box>();

    public static readonly StyledProperty<double> heightProperty =
        Window.HeightProperty.AddOwner<box>();

    public static readonly StyledProperty<string?> markProperty =
        Window.TitleProperty.AddOwner<box>();
    
    public double width
    {
        get { return GetValue(widthProperty); }
        set { SetValue(widthProperty, value); }
    }

    public double height
    {
        get { return GetValue(heightProperty); }
        set { SetValue(heightProperty, value); }
    }
    
    public string? mark
    {
        get { return GetValue(markProperty); }
        set { SetValue(markProperty, value); }
    }
}
