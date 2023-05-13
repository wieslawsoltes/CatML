using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;

namespace CatML;

public class carpet : Canvas, IStyleable
{
    Type IStyleable.StyleKey => typeof(Canvas);

    public static readonly DirectProperty<carpet, string?> nameProperty =
        Canvas.NameProperty.AddOwner<carpet>(o => o.Name, (o, v) => o.Name = v);

    public static readonly StyledProperty<double> widthProperty =
        Canvas.WidthProperty.AddOwner<carpet>();

    public static readonly StyledProperty<double> heightProperty =
        Canvas.HeightProperty.AddOwner<carpet>();

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
}
