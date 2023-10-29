using AnatomyAnalyzer.Local.Helpers;
using AnatomyAnalyzer.Local.Models;
using AnatomyAnalyzer.Local.ViewModels;
using AnatomyAnalyzer.UI.Views;
using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Mvvm;
using System.Windows;

namespace AnatomyAnalyzer.Controls
{
    public abstract class AnatomyApplication : JamesApplication
    {
        AnatomyItemCollection _items;
        private AnatomyWindow _window;

        protected override Window CreateShell()
        {
            _window = new AnatomyWindow();

            return _window;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            _items = new();
            RegisterControls(_items);

            var service = GetService<AnatomyService>();

            service.Add(_items);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            base.RegisterTypes(containerRegistry);

            containerRegistry.RegisterSingleton<AnatomyService>();
            containerRegistry.RegisterSingleton<IViewable, MainContent>("MainContent");
            containerRegistry.RegisterSingleton<IViewable, CurrentContent>("CurrentContent");
            ViewModelLocationProvider.Register<AnatomyWindow, AnatomyWindowViewModel>();
            ViewModelLocationProvider.Register<MainContent, MainContentViewModel>();
            ViewModelLocationProvider.Register<CurrentContent, CurrentContentViewModel>();
        }

        protected virtual void RegisterControls(AnatomyItemCollection items)
        {

        }
    }
}
