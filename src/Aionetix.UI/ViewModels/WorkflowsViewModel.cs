using ReactiveUI;

namespace Aionetix.UI.ViewModels;

public class WorkflowsViewModel : ReactiveObject, IRoutableViewModel
{
    public string UrlPathSegment => "Workflows";
    public IScreen HostScreen { get; }

    public WorkflowsViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}