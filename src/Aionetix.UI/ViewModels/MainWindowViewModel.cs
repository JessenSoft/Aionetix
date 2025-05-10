using ReactiveUI;
using Splat;

namespace Aionetix.UI.ViewModels;

public class MainWindowViewModel : ReactiveObject, IScreen
{
    public RoutingState Router { get; } = new();

    public MainWindowViewModel()
    {
        // Initiale View laden
        Router.Navigate.Execute(new HomeViewModel(this));
    }
}