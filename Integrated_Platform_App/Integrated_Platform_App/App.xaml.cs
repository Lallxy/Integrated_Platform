
using Integrated_Platform_App.ViewModels;
using Integrated_Platform_App.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Integrated_Platform_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainView, MainViewModel>();
            containerRegistry.RegisterForNavigation<HomeView,HomeViewModel>();
           // containerRegistry.RegisterSingleton<App_DbContext>();
        }

    }

}
