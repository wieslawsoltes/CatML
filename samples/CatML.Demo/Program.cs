using Avalonia;
using System;

namespace CatML.Demo;

class Program
{
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<lair>()
            .UsePlatformDetect()
            .LogToTrace();
}
