using Anatomy.Analysis.UI.Views;
using Anatomy.Main.UI.Views;
using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Modularity;

namespace Anatomy.Properties
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, MainContent>("MainContent");
            containerRegistry.RegisterSingleton<IViewable, AnalysisContent>("CurrentContent");
        }
    }
}
