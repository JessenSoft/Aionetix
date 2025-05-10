using ReactiveUI;
using System.Windows.Controls;
using Aionetix.UI.ViewModels;

namespace Aionetix.UI.Views;

public partial class WorkflowsView : UserControl, IViewFor<WorkflowsViewModel>
{
    public WorkflowsView()
    {
        InitializeComponent();
    }

    public WorkflowsViewModel ViewModel
    {
        get => (WorkflowsViewModel)DataContext!;
        set => DataContext = value;
    }

    object? IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = (WorkflowsViewModel)value!;
    }
}