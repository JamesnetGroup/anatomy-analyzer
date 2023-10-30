using Anatomy.Analysis.Local.ViewModels;
using Anatomy.Analysis.UI.Views;
using Anatomy.Forms.Local.ViewModels;
using Anatomy.Forms.UI.Views;
using Anatomy.Main.Local.ViewModels;
using Anatomy.Main.UI.Views;
using Jamesnet.Wpf.Global.Location;
using Prism.Mvvm;

namespace Anatomy.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            ViewModelLocationProvider.Register<AnatomyWindow, AnatomyWindowViewModel>();
            ViewModelLocationProvider.Register<MainContent, MainContentViewModel>();
            ViewModelLocationProvider.Register<AnalysisContent, CurrentContentViewModel>();
        }
    }
}
