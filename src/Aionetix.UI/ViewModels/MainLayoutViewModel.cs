using ReactiveUI;
using System.Reactive;
using Aionetix.UI.ViewModels;

namespace Aionetix.UI.ViewModels
{
    /// <summary>
    /// Das MainLayoutViewModel steuert die Hauptnavigation und enthält die Sidebar sowie den zentralen Router.
    /// </summary>
    public class MainLayoutViewModel : ReactiveObject, IRoutableViewModel, IScreen
    {
        #region Properties

        public string UrlPathSegment => "Main";
        public IScreen HostScreen => this;

        public RoutingState Router { get; } = new();

        public SidebarViewModel Sidebar { get; }

        public ReactiveCommand<Unit, IRoutableViewModel> ShowDashboards { get; }
        public ReactiveCommand<Unit, IRoutableViewModel> ShowWorkflows { get; }
        public ReactiveCommand<Unit, IRoutableViewModel> ShowJobMonitor { get; }
        public ReactiveCommand<Unit, IRoutableViewModel> ShowSettings { get; }

        #endregion Properties

        #region Constructor

        public MainLayoutViewModel()
        {
            // Initialisiere Sidebar
            Sidebar = new SidebarViewModel(this);

            // Kommandos definieren
            ShowDashboards = ReactiveCommand.CreateFromObservable(() =>
                Router.Navigate.Execute(new DashboardsViewModel(this)));

            ShowWorkflows = ReactiveCommand.CreateFromObservable(() =>
                Router.Navigate.Execute(new WorkflowsViewModel(this)));

            ShowJobMonitor = ReactiveCommand.CreateFromObservable(() =>
                Router.Navigate.Execute(new JobMonitorViewModel(this)));

            ShowSettings = ReactiveCommand.CreateFromObservable(() =>
                Router.Navigate.Execute(new SettingsViewModel(this)));

            // Startansicht festlegen
            Router.Navigate.Execute(new DashboardsViewModel(this)).Subscribe();
        }

        #endregion Constructor
    }
}