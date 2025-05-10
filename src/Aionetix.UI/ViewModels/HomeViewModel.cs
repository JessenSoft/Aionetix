using ReactiveUI;
using Splat;

namespace Aionetix.UI.ViewModels;

/// <summary>
/// Startseite.
/// </summary>
public class HomeViewModel : ReactiveObject, IRoutableViewModel
{
    public string UrlPathSegment => "home";
    public IScreen HostScreen { get; }

    public HomeViewModel(IScreen? screen = null)
    {
        HostScreen = screen ?? Locator.Current.GetService<IScreen>()!;
        Console.WriteLine("HomeViewModel navigated");
    }
}