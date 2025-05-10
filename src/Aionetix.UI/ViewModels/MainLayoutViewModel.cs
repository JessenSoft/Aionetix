using ReactiveUI;
using System.Reactive;
using System.Reactive.Linq;

namespace Aionetix.UI.ViewModels;

public class MainLayoutViewModel : ReactiveObject, IScreen
{
    public RoutingState Router { get; } = new();

    public ReactiveCommand<Unit, IRoutableViewModel> ShowWorkflowsCommand { get; }
    public ReactiveCommand<Unit, IRoutableViewModel> ShowDashboardsCommand { get; }
    public ReactiveCommand<Unit, IRoutableViewModel> ShowJobMonitorCommand { get; }
    public ReactiveCommand<Unit, IRoutableViewModel> ShowSettingsCommand { get; }

    public MainLayoutViewModel()
    {
        ShowWorkflowsCommand = ReactiveCommand.CreateFromObservable(
            () => Router.Navigate.Execute(new WorkflowsViewModel(this)));

        ShowDashboardsCommand = ReactiveCommand.CreateFromObservable(
            () => Router.Navigate.Execute(new DashboardsViewModel(this)));

        ShowJobMonitorCommand = ReactiveCommand.CreateFromObservable(
            () => Router.Navigate.Execute(new JobMonitorViewModel(this)));

        ShowSettingsCommand = ReactiveCommand.CreateFromObservable(
            () => Router.Navigate.Execute(new SettingsViewModel(this)));
    }

    public IObservable<IRoutableViewModel> CurrentContent => Router.CurrentViewModel;
}