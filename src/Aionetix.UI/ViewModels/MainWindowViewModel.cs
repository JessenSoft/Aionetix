using ReactiveUI;

namespace Aionetix.UI.ViewModels;

/// <summary>
/// Root-Screen für die Anwendung.
/// </summary>
public class MainWindowViewModel : ReactiveObject, IScreen
{
    /// <summary>
    /// Router für Navigation.
    /// </summary>
    public RoutingState Router { get; } = new();
}