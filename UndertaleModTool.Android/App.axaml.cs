using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace UndertaleModTool.Android;

public partial class App : Avalonia.Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is ISingleViewApplicationLifetime singleView)
        {
            // Isso garante que o app tenha algo para mostrar na tela e não feche sozinho
            singleView.MainView = new UserControl
            {
                Background = Brushes.Black,
                Content = new TextBlock
                {
                    Text = "UndertaleModTool Iniciou com Sucesso!",
                    Foreground = Brushes.White,
                    HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                    VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
                }
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
