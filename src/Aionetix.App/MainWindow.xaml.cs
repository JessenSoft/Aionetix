using System.Windows;
using ReactiveUI;
using Aionetix.UI.ViewModels;

namespace Aionetix.App;

public partial class MainWindow : Window, IViewFor<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
        ViewModel = new MainWindowViewModel();
        DataContext = ViewModel;

        ViewModel.Router.Navigate.Execute(new HomeViewModel(ViewModel));
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
        get => ViewModel;
        set => ViewModel = (MainWindowViewModel)value;
    }
}