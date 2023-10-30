using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Controls;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Anatomy.Support.Local.Models
{
    public partial class AnatomyItem : ObservableObject
    {
        public string Name { get; set; }
        public IconType IconType { get; set; }
        public Type Type { get; set; }
        public Type ControlType { get; set; }
        public DependencyObject Instance { get; set; }
        public ObservableCollection<AnatomyItem> Children { get; set; }
        public ObservableCollection<DetailInfo> Items { get; set; }
        public Control Content { get; set; }
        public int Depth { get; set; }

        [ObservableProperty]
        private bool _isFolderExpanded;

        [ObservableProperty]
        private bool _isFolderSelected;
    }
}