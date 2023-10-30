using Anatomy.Support.Local.Helpers;
using Prism.Ioc;
using Prism.Modularity;

namespace Anatomy.Properties
{
    internal class HelperModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<AnatomyService>();
        }
    }
}
