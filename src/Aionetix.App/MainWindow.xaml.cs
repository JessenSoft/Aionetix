using System.Windows;
using ReactiveUI;
using Aionetix.UI.ViewModels;

namespace Aionetix.App
{
    public partial class MainWindow : Window, IViewFor<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();

            ViewModel = new MainWindowViewModel();
            DataContext = ViewModel;

            // 🧠 WPF-DataBinding übernimmt den Router automatisch per DataContext
            // Kein explizites Setzen von Router nötig

            // ➕ Navigation starten
            ViewModel.Router.Navigate.Execute(new HomeViewModel(ViewModel));
        }

        public MainWindowViewModel ViewModel
        {
            get => (MainWindowViewModel)DataContext!;
            set => DataContext = value;
        }

        object? IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (MainWindowViewModel)value!;
        }
    }
}