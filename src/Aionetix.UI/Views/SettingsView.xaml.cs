using ReactiveUI;
using System.Windows.Controls;
using Aionetix.UI.ViewModels;

namespace Aionetix.UI.Views;

public partial class SettingsView : UserControl, IViewFor<SettingsViewModel>
{
    public SettingsView()
    {
        InitializeComponent();
    }

    public SettingsViewModel ViewModel
    {
        get => (SettingsViewModel)DataContext!;
        set => DataContext = value;
    }

    object? IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = (SettingsViewModel)value!;
    }
}