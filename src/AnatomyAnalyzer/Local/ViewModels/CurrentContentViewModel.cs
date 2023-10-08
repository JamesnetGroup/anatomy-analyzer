using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using AnatomyAnalyzer.Local.Models;
using System.Windows.Shapes;
using AnatomyAnalyzer.Local.Helpers;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Data;

namespace AnatomyAnalyzer.Local.ViewModels
{
    public partial class CurrentContentViewModel : ObservableBase
    {
        private readonly AnatomyService _anatomyService;
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;

        public Dictionary<AnatomyItem, AnatomyItem> Instances { get; set; }

        public ObservableCollection<AnatomyItem> Controls { get; set; }

        [ObservableProperty]
        private AnatomyItem _current;

        public CurrentContentViewModel(AnatomyService anatomyService, IContainerProvider containerProvider, IRegionManager regionManager)
        {
            Instances = new();
            Controls = new();
            _anatomyService = anatomyService;
            _containerProvider = containerProvider;
            _regionManager = regionManager;
            _anatomyService.ControlSelected += _anatomyService_ControlSelected;
        }

        private void _anatomyService_ControlSelected(object sender, AnatomyEventArgs e)
        {
            Current = GetControl(e.Item);
        }

        private AnatomyItem GetControl(AnatomyItem item)
        {
            if (!Instances.ContainsKey(item))
            {
                Control control = (Control)Activator.CreateInstance(item.Type);
                item.Instance = control;
                control.Loaded += Control_Loaded;
                Instances.Add(item, item);
            }
            return Instances[item];
        }

        private void Control_Loaded(object sender, RoutedEventArgs e)
        {
            List<DependencyObject> allChildren = new List<DependencyObject>();
            if (Current.Instance is DependencyObject instance)
            {
                allChildren.Add(instance); 
            }
            allChildren.AddRange(GetAllChildren(Current.Instance));

            Current.Items.Clear();

            foreach (var child in allChildren)
            {
                if (child is FrameworkElement element)
                {
                    VisualBrush brush = new VisualBrush(element);
                    brush.Stretch = Stretch.None;

                    Rectangle rect = new Rectangle();
                    rect.VerticalAlignment = VerticalAlignment.Bottom;
                    Binding widthBinding = new Binding("ActualWidth");
                    widthBinding.Source = element;
                    rect.SetBinding(Rectangle.WidthProperty, widthBinding);

                    Binding heightBinding = new Binding("ActualHeight");
                    heightBinding.Source = element;
                    rect.SetBinding(Rectangle.HeightProperty, heightBinding);

                    rect.Fill = brush;

                    var item = new DetailInfo();
                    item.Content = rect;
                    item.Name = element.GetType().Name;
                    item.Instance = element;
                    Current.Items.Add(item);
                }
            }

            _anatomyService.LoadControl(Current);
        }

        private List<DependencyObject> GetAllChildren(DependencyObject parent)
        {
            var allChildren = new List<DependencyObject>();

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                allChildren.Add(child);

                allChildren.AddRange(GetAllChildren(child));
            }

            return allChildren;
        }
    }
}
