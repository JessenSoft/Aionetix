using Aionetix.UI.ViewModels;
using Aionetix.UI.Views;
using ReactiveUI;
using Splat;

namespace Aionetix.App;

public partial class App
{
    public App()
    {
        InitializeComponent();
        RegisterViews();
    }

    private void RegisterViews()
    {
        Locator.CurrentMutable.Register(() => new HomeView(), typeof(IViewFor<HomeViewModel>));
    }
}