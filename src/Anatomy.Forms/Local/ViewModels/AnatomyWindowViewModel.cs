using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Global.Composition;
using Jamesnet.Wpf.Mvvm;

namespace Anatomy.Forms.Local.ViewModels
{
    public partial class AnatomyWindowViewModel : ObservableBase, IViewLoadable
    {
        private readonly ContentManager _contentManager;

        public AnatomyWindowViewModel(ContentManager contentManager)
        {
            _contentManager = contentManager;
        }

        public void OnLoaded(IViewable view)
        {
            _contentManager.ActiveContent("MainRegion", "MainContent");
        }
    }
}
