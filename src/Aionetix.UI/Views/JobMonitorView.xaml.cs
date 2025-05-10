using ReactiveUI;
using System.Windows.Controls;
using Aionetix.UI.ViewModels;

namespace Aionetix.UI.Views;

public partial class JobMonitorView : UserControl, IViewFor<JobMonitorViewModel>
{
    public JobMonitorView()
    {
        InitializeComponent();
    }

    public JobMonitorViewModel ViewModel
    {
        get => (JobMonitorViewModel)DataContext!;
        set => DataContext = value;
    }

    object? IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = (JobMonitorViewModel)value!;
    }
}