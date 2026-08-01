using Android.App;
using Android.Content.PM;
using Avalonia.Android;
using UndertaleModTool;

namespace UndertaleModTool.Android;

[Activity(
    Label = "@string/app_name",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity<App>
{
}
