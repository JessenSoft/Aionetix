using ReactiveUI;
using Aionetix.UI.ViewModels;
using Aionetix.UI.Views;

namespace Aionetix.UI;

public class ViewLocator : IViewLocator
{
    public IViewFor? ResolveView<T>(T? viewModel, string? contract = null)
    {
        return viewModel switch
        {
            DashboardsViewModel => new DashboardsView(),
            WorkflowsViewModel => new WorkflowsView(),
            JobMonitorViewModel => new JobMonitorView(),
            SettingsViewModel => new SettingsView(),
            MainLayoutViewModel => new MainLayoutView(),
            HomeViewModel => new HomeView(),
            MainWindowViewModel => new MainLayoutView(),
            _ => null
        };
    }
}