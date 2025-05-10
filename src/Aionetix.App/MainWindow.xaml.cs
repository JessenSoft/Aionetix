using Aionetix.UI.ViewModels;
using ReactiveUI;
using System.Windows;

namespace Aionetix.App;

public partial class MainWindow : Window, IViewFor<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();

        ViewModel = new MainWindowViewModel();
        DataContext = ViewModel;

        var homeViewModel = new HomeViewModel(ViewModel);

        RouterHost.ViewModel = homeViewModel; // 🔁 direkt setzen, kein Routing
        Console.WriteLine("✅ RouterHost.ViewModel gesetzt");
    }

    public static readonly DependencyProperty ViewModelProperty =
        DependencyProperty.Register(nameof(ViewModel), typeof(MainWindowViewModel), typeof(MainWindow));

    public MainWindowViewModel ViewModel
    {
        get => (MainWindowViewModel)GetValue(ViewModelProperty);
        set => SetValue(ViewModelProperty, value);
    }

    object IViewFor.ViewModel
    {
        get => ViewModel!;
        set => ViewModel = (MainWindowViewModel)value;
    }
}