using Jamesnet.Wpf.Controls;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace AnatomyAnalyzer.Local.Models
{
    public class AnatomyItem
    {
        public string Name { get; internal set; }
        public IconType IconType { get; internal set; }
        public Type Type { get; internal set; }
        public Type ControlType { get; internal set; }
        public DependencyObject Instance { get; internal set; }
        public List<AnatomyItem> Children { get; internal set; }
        public ObservableCollection<DetailInfo2> Items { get; set; }
        public Control Content { get; internal set; }
    }
}