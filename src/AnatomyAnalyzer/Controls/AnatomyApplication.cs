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
    public abstract class AnatomyApplication2 : JamesApplication
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

            var service = GetService<AnatomyService2>();

            service.Add(_items);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            base.RegisterTypes(containerRegistry);

            containerRegistry.RegisterSingleton<AnatomyService2>();
            ViewModelLocationProvider.Register<AnatomyWindow, AnatomyWindowViewModel>();
        }

        protected virtual void RegisterControls(AnatomyItemCollection items)
        {

        }
    }
}
