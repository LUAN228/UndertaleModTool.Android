using Avalonia;
using Avalonia.Android;

namespace UndertaleModTool.Android;

public class Program
{
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithAndroidIntent(args);

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace();
}
