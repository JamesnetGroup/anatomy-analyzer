using AnatomyAnalyzer.Local.Models;
using Prism.Regions;
using System.Windows.Controls;
using System.Windows;
using AnatomyAnalyzer.UI.Views;
using System.Windows.Media;
using System.Windows.Shapes;

namespace AnatomyAnalyzer.Local.Helpers
{
    public class AnatomyService
    {
        public event EventHandler<AnatomyChangedEventArgs> ControlSelected;

        public event EventHandler<AnatomyChangedEventArgs> AnatomyControlChanged;
        public Dictionary<Type, DependencyObject> Instances { get; set; }

        internal void Add(AnatomyItemCollection items)
        {
            var args = new AnatomyChangedEventArgs();
            args.Controls = items;
            AnatomyControlChanged.Invoke(this, args);
        }

        internal void SelectControl(AnatomyItem item)
        {
            AnatomyChangedEventArgs args = new();
            args.Item = item;
            ControlSelected.Invoke(this, args);
            //IRegion region = _regionManager.Regions[regionName];
            //DependencyObject content = GetControl(item);

            //if (content is ContentControl contentControl)
            //{
            //    item.Instance = contentControl.Content as DependencyObject;

            //}

            //if (!region.Views.Contains(content))
            //{
            //    region.Add(content);
            //}
            //region.Activate(content);
        }
    }
}
