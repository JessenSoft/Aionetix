using Aionetix.UI.ViewModels;
using ReactiveUI;
using System.Windows.Controls;

public partial class SidebarView : UserControl, IViewFor<SidebarViewModel>
{
    public SidebarView()
    {
        InitializeComponent();
    }

    public SidebarViewModel ViewModel
    {
        get => (SidebarViewModel)DataContext!;
        set => DataContext = value;
    }

    object? IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = (SidebarViewModel)value!;
    }
}