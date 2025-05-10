using ReactiveUI;

namespace Aionetix.UI.ViewModels;

public class DashboardsViewModel : ReactiveObject, IRoutableViewModel
{
    public string UrlPathSegment => "Dashboards";
    public IScreen HostScreen { get; }

    public DashboardsViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}