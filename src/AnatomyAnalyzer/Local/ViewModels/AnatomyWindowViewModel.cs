using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
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
using AnatomyAnalyzer.UI.Units;

namespace AnatomyAnalyzer.Local.ViewModels
{
    public partial class AnatomyWindowViewModel : ObservableBase, IViewLoadable
    {
        private readonly AnatomyService2 _anatomyService;
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;

        public Dictionary<Type, DependencyObject> Instances { get; set; }

        public ObservableCollection<AnatomyItem2> Controls { get; set; }

        public AnatomyWindowViewModel(AnatomyService2 anatomyService, IContainerProvider containerProvider, IRegionManager regionManager)
        {
            Instances = new();
            Controls = new();
            _anatomyService = anatomyService;
            _containerProvider = containerProvider;
            _regionManager = regionManager;
            _anatomyService.AnatomyControlChanged += _anatomyService_AnatomyControlChanged;
        }

        public void OnLoaded(IViewable view)
        {
        }

        private void _anatomyService_AnatomyControlChanged(object sender, AnatomyChangedEventArgs e)
        {
            foreach (Type item in e.Controls)
            {
                if (item.IsSubclassOf(typeof(Control)))
                {
                    //Control control = (Control)Activator.CreateInstance(item);
                    //Instance.Children.Add(control);

                    AnatomyItem2 anatomyItem = new();
                    anatomyItem.Name = item.Name;
                    anatomyItem.Type = item;
                    anatomyItem.IconType = IconType.ButtonCursor;
                    anatomyItem.Items = new();
                    Controls.Add(anatomyItem);
                }
            }
        }

        [RelayCommand]
        private void TreeItemSelected(AnatomyItem2 anatomyItem)
        {
            ImportContent("AnatomyObjectRegion", anatomyItem);
        }

        private void ImportContent(string regionName, AnatomyItem2 item)
        {
            IRegion region = _regionManager.Regions[regionName];
            DependencyObject content = GetControl(item);

            if (content is ContentControl contentControl)
            {
                item.Instance = contentControl.Content as DependencyObject;

            }

            if (!region.Views.Contains(content))
            {
                region.Add(content);
            }
            region.Activate(content);
        }

        private DependencyObject GetControl(AnatomyItem2 item)
        {
            if (!Instances.ContainsKey(item.Type))
            {
                Control control = (Control)Activator.CreateInstance(item.Type);
                AnatomyView preview = new();
                preview.Loaded += Preview_Loaded;
                preview.Content = control;
                preview.DataContext = item;
                Instances.Add(item.Type, preview);
            }
            return Instances[item.Type];
        }

        private void Preview_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement fe && fe.DataContext is AnatomyItem2 anatomyItem)
            {
                List<DependencyObject> allChildren = new List<DependencyObject>();
                if (anatomyItem.Instance is DependencyObject instance)
                {
                    allChildren.Add(instance); // 여기서 인스턴스 자기 자신을 추가합니다.
                }
                allChildren.AddRange(GetAllChildren(anatomyItem.Instance));

                anatomyItem.Items.Clear();

                foreach (var child in allChildren)
                {
                    if (child is FrameworkElement element)
                    {
                        VisualBrush brush = new VisualBrush(element);
                        brush.Stretch = Stretch.None;

                        Rectangle rect = new Rectangle();
                        rect.Width = element.ActualWidth;
                        rect.Height = element.ActualHeight;
                        rect.Fill = brush;

                        var item = new DetailInfo2();
                        item.Content = rect;
                        item.Name = element.GetType().Name;
                        item.Instance = element;
                        anatomyItem.Items.Add(item);
                    }
                }
            }
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


        List<AnatomyItem2> source = new List<AnatomyItem2>();

        void AddControl(object obj)
        {
            if (obj is DependencyObject dependencyObject)
            {
                AnatomyItem2 controlInfo = new AnatomyItem2
                {
                    Name = obj.GetType().Name,
                    ControlType = obj.GetType(),
                    Instance = dependencyObject
                };

                AddChildControls(controlInfo, dependencyObject); // 자식 컨트롤들을 추가합니다.

                source.Add(controlInfo); // 루트 컨트롤만 source 리스트에 추가합니다.
            }
        }

        void AddChildControls(AnatomyItem2 parentControlInfo, DependencyObject parentDependencyObject)
        {
            int childrenCount = VisualTreeHelper.GetChildrenCount(parentDependencyObject);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parentDependencyObject, i);
                AnatomyItem2 childControlInfo = new AnatomyItem2
                {
                    Name = child.GetType().Name,
                    ControlType = child.GetType(),
                    Instance = child
                };
                parentControlInfo.Children.Add(childControlInfo); // 자식 ControlInfo를 Children 리스트에 추가합니다.

                if (child is DependencyObject childDependencyObject)
                    AddChildControls(childControlInfo, childDependencyObject); // 재귀적으로 하위 컨트롤들을 추가합니다.
            }
        }
    }
}
