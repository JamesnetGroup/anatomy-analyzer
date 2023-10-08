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
using AnatomyAnalyzer.Local.Helpers;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Xml.Linq;

namespace AnatomyAnalyzer.Local.ViewModels
{
    public partial class AnatomyWindowViewModel : ObservableBase, IViewLoadable
    {
        private readonly AnatomyService _anatomyService;
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;

        public Dictionary<Type, DependencyObject> Instances { get; set; }

        public ObservableCollection<AnatomyItem> Controls { get; set; }

        public ObservableCollection<AnatomyItem> Childs { get; set; }

        public ObservableCollection<PropertyItem> Properties { get; set; }

        [ObservableProperty]
        public string _templateXaml;

        public AnatomyWindowViewModel(AnatomyService anatomyService, IContainerProvider containerProvider, IRegionManager regionManager)
        {
            Instances = new();
            Controls = new();
            Childs = new();
            Properties = new();

            _anatomyService = anatomyService;
            _containerProvider = containerProvider;
            _regionManager = regionManager;
            _anatomyService.ControlChanged += ControlChanged;
            _anatomyService.ControlLoaded += ControlLoaded;
        }

        private void ControlLoaded(object sender, AnatomyEventArgs e)
        {
            List<AnatomyItem> result = new();

            AnatomyItem selfItem = new()
            {
                Name = e.Item.Instance.GetType().Name,
                Type = e.Item.Instance.GetType(),
                Children = new(),
                Instance = e.Item.Instance,
                Depth = 0
            };
            result.Add(selfItem);
            selfItem.Children.AddRange(ConvertToAnatomyItems(e.Item.Instance as DependencyObject));

            
            Childs.Clear();
            Childs.AddRange(result);

            if (e.Item.Instance is Control control)
            {
                Style style = Application.Current.TryFindResource(control.GetType()) as Style;

                if (style != null)
                {
                    string raw = System.Windows.Markup.XamlWriter.Save(style);

                    TemplateXaml = FormatXaml(raw);
                }
            }
        }

        public string FormatXaml(string xamlString)
        {
            var xDocument = XDocument.Parse(xamlString);
            return xDocument.ToString();
        }

        private List<AnatomyItem> ConvertToAnatomyItems(DependencyObject parent, int currentDepth = 1)
        {
            var result = new List<AnatomyItem>();

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                AnatomyItem childItem = new()
                {
                    Name = child.GetType().Name,
                    Type = child.GetType(),
                    Instance = child,
                    Depth = currentDepth
                };

                childItem.Children = new ObservableCollection<AnatomyItem>(ConvertToAnatomyItems(child, currentDepth + 1));
                result.Add(childItem);
            }

            return result;
        }

        public void OnLoaded(IViewable view)
        {
            ImportContent("ContentRegion", "CurrentContent");
        }

        private void ControlChanged(object sender, AnatomyEventArgs e)
        {
            foreach (Type item in e.Controls)
            {
                if (item.IsSubclassOf(typeof(Control)))
                {
                    AnatomyItem anatomyItem = new()
                    {
                        Name = item.Name,
                        Type = item,
                        IconType = GetRandomIconType(),
                        Items = new(),
                        IsFolderExpanded = true
                    };
                    Controls.Add(anatomyItem);
                }
            }
        }

        public static IconType GetRandomIconType()
        {
            var values = Enum.GetValues(typeof(IconType));
            Random random = new Random();
            return (IconType)values.GetValue(random.Next(values.Length));
        }

        [RelayCommand]
        private void TreeItemSelected(AnatomyItem anatomyItem)
        {
            _anatomyService.SelectControl(anatomyItem);
        }

        [RelayCommand]
        private void ChildSelection(AnatomyItem item)
        { 
            LoadProperties(item.Instance);
        }

        public void LoadProperties(object obj)
        {
            Properties.Clear();
            if (obj == null) return;

            var type = obj.GetType();
            foreach (var prop in type.GetProperties())
            {
                if (prop.CanRead && prop.CanWrite)
                {
                    var propertyItem = new PropertyItem
                    {
                        Name = prop.Name,
                        OriginalObject = obj,
                        PropertyInfo = prop,
                        Value = prop.GetValue(obj),
                    };
                    Properties.Add(propertyItem);
                }
            }
        }

        private void ImportContent(string regionName, string contentName)
        {
            IRegion region = _regionManager.Regions[regionName];
            IViewable content = _containerProvider.Resolve<IViewable>(contentName);

            if (!region.Views.Contains(content))
            {
                region.Add(content);
            }
            region.Activate(content);
        }
    }
}
