using ReactiveUI;
using System.Reactive;
using Aionetix.UI.ViewModels;

namespace Aionetix.UI.ViewModels
{
    /// <summary>
    /// ViewModel für die linke Sidebar-Navigation.
    /// </summary>
    public class SidebarViewModel : ReactiveObject
    {
        public ReactiveCommand<Unit, Unit> OpenDashboardsCommand { get; }
        public ReactiveCommand<Unit, Unit> OpenWorkflowsCommand { get; }
        public ReactiveCommand<Unit, Unit> OpenJobMonitorCommand { get; }
        public ReactiveCommand<Unit, Unit> OpenSettingsCommand { get; }

        public SidebarViewModel(MainLayoutViewModel main)
        {
            OpenDashboardsCommand = ReactiveCommand.CreateFromObservable(() =>
                main.Router.Navigate.Execute(new DashboardsViewModel(main)));

            OpenWorkflowsCommand = ReactiveCommand.CreateFromObservable(() =>
                main.Router.Navigate.Execute(new WorkflowsViewModel(main)));

            OpenJobMonitorCommand = ReactiveCommand.CreateFromObservable(() =>
                main.Router.Navigate.Execute(new JobMonitorViewModel(main)));

            OpenSettingsCommand = ReactiveCommand.CreateFromObservable(() =>
                main.Router.Navigate.Execute(new SettingsViewModel(main)));
        }
    }
}