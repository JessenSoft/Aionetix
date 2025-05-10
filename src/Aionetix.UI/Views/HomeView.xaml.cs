using ReactiveUI;
using Aionetix.UI.ViewModels;
using System.Windows.Controls;

namespace Aionetix.UI.Views;

public partial class HomeView : UserControl, IViewFor<HomeViewModel>
{
    public HomeView()
    {
        InitializeComponent();
    }

    public HomeViewModel? ViewModel
    {
        get => (HomeViewModel?)DataContext;
        set => DataContext = value;
    }

    object? IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = (HomeViewModel?)value;
    }
}