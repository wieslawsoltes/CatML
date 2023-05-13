using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;

namespace CatML;

public class option : ComboBoxItem, IStyleable
{
    Type IStyleable.StyleKey => typeof(ComboBoxItem);

    public static readonly DirectProperty<option, string?> nameProperty =
        ComboBoxItem.NameProperty.AddOwner<option>(o => o.Name, (o, v) => o.Name = v);
}
