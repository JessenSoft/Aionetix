using ReactiveUI;
using System.Windows.Controls;
using Aionetix.UI.ViewModels;

namespace Aionetix.UI.Views;

public partial class DashboardsView : UserControl, IViewFor<DashboardsViewModel>
{
    public DashboardsView()
    {
        InitializeComponent();
    }

    public DashboardsViewModel ViewModel
    {
        get => (DashboardsViewModel)DataContext!;
        set => DataContext = value;
    }

    object? IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = (DashboardsViewModel)value!;
    }
}