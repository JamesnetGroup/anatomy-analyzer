using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using AnatomyAnalyzer.Local.Models;
using AnatomyAnalyzer.Local.Helpers;
using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Global.Composition;
using Jamesnet.Wpf.Composition;

namespace AnatomyAnalyzer.Local.ViewModels
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
