using System.Windows;
using Aionetix.UI.Views;
using Aionetix.UI.ViewModels;

namespace Aionetix.App;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        // Beispiel: HomeView mit ViewModel anzeigen
        var view = new HomeView
        {
            ViewModel = new HomeViewModel()
        };

        ContentHost.Content = view;
    }
}