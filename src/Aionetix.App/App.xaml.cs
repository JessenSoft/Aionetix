using System.Windows;
using ReactiveUI;
using Splat;
using Aionetix.UI.ViewModels;
using Aionetix.UI.Views;

namespace Aionetix.App;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        Locator.CurrentMutable.Register(() => new HomeView(), typeof(IViewFor<HomeViewModel>));
    }
}