using ReactiveUI;

namespace Aionetix.UI.ViewModels;

public class JobMonitorViewModel : ReactiveObject, IRoutableViewModel
{
    public string UrlPathSegment => "JobMonitor";
    public IScreen HostScreen { get; }

    public JobMonitorViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}