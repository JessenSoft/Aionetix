using ReactiveUI;

namespace Aionetix.UI.ViewModels;

public class SettingsViewModel : ReactiveObject, IRoutableViewModel
{
    public string UrlPathSegment => "Settings";
    public IScreen HostScreen { get; }

    public SettingsViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}