using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Controls;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace AnatomyAnalyzer.Local.Models
{
    public partial class AnatomyItem :ObservableObject
    {
        public string Name { get; internal set; }
        public IconType IconType { get; internal set; }
        public Type Type { get; internal set; }
        public Type ControlType { get; internal set; }
        public DependencyObject Instance { get; internal set; }
        public ObservableCollection<AnatomyItem> Children { get; internal set; }
        public ObservableCollection<DetailInfo> Items { get; set; }
        public Control Content { get; internal set; }
        public int Depth { get; internal set; }

        [ObservableProperty]
        private bool _isFolderExpanded;

        [ObservableProperty]
        private bool _isFolderSelected;
    }
}