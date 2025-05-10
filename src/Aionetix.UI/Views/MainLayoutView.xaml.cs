using ReactiveUI;
using System.Windows.Controls;
using Aionetix.UI.ViewModels;

namespace Aionetix.UI.Views;

public partial class MainLayoutView : UserControl, IViewFor<MainLayoutViewModel>
{
    public MainLayoutView()
    {
        InitializeComponent();
    }

    public MainLayoutViewModel ViewModel
    {
        get => (MainLayoutViewModel)DataContext!;
        set => DataContext = value;
    }

    object? IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = (MainLayoutViewModel)value!;
    }
}