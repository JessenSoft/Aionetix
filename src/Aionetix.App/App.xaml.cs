using System.Windows;
using ReactiveUI;
using Aionetix.UI;
using Splat;

namespace Aionetix.App
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // ViewLocator für ReactiveUI setzen
            Locator.CurrentMutable.RegisterConstant(new Aionetix.UI.ViewLocator(), typeof(IViewLocator));
        }
    }
}