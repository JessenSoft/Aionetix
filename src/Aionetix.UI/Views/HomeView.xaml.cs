using ReactiveUI;
using System.Windows.Controls;
using Aionetix.UI.ViewModels;
using System.Windows;

namespace Aionetix.UI.Views;

public partial class HomeView : UserControl, IViewFor<HomeViewModel>
{
    public HomeView()
    {
        Console.WriteLine("✅ HomeView erzeugt");
        InitializeComponent();
    }

    public HomeViewModel ViewModel
    {
        get => (HomeViewModel)GetValue(ViewModelProperty);
        set => SetValue(ViewModelProperty, value);
    }

    public static readonly DependencyProperty ViewModelProperty =
        DependencyProperty.Register(nameof(ViewModel), typeof(HomeViewModel), typeof(HomeView));

    object IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = (HomeViewModel)value;
    }
}