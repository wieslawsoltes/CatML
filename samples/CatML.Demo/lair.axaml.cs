using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace CatML.Demo;

public partial class lair : alley
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new mainBox();
        }

        base.OnFrameworkInitializationCompleted();
    }
}
