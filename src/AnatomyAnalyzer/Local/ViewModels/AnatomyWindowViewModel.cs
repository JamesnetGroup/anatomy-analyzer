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

namespace AnatomyAnalyzer.Local.ViewModels
{
    public partial class AnatomyWindowViewModel : ObservableBase, IViewLoadable
    {
        private readonly AnatomyService _anatomyService;
        private readonly ContentManager _contentManager;

        public Dictionary<Type, DependencyObject> Instances { get; set; }
        public ObservableCollection<AnatomyItem> Controls { get; set; }
        public ObservableCollection<AnatomyItem> Childs { get; set; }
        public ObservableCollection<PropertyItem> Properties { get; set; }

        [ObservableProperty]
        private object _instance;

        public AnatomyWindowViewModel(ContentManager contentManager, AnatomyService anatomyService)
        {
            Instances = new();
            Controls = new();
            Childs = new();
            Properties = new();

            _contentManager = contentManager;
            _anatomyService = anatomyService;
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

            Childs[0].IsFolderExpanded = true;
            Childs[0].IsFolderSelected = true;
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
                    Instance = (DependencyObject)child,
                    Depth = currentDepth
                };

                childItem.Children = new ObservableCollection<AnatomyItem>(ConvertToAnatomyItems(child, currentDepth + 1));
                result.Add(childItem);
            }

            return result;
        }

        public void OnLoaded(IViewable view)
        {
            _contentManager.ActiveContent("ContentRegion", "CurrentContent");
        }

        private void ControlChanged(object sender, AnatomyEventArgs e)
        {
            foreach (var item in e.Controls)
            {
                if (item is Type type && type.IsSubclassOf(typeof(Control)))
                {
                    AnatomyItem anatomyItem = new()
                    {
                        Name = type.Name,
                        Type = type,
                        IconType = GetRandomIconType(),
                        Items = new(),
                        IsFolderExpanded = true
                    };
                    Controls.Add(anatomyItem);
                }
                else if (item is Control control)
                {
                    AnatomyItem anatomyItem = new()
                    {
                        Name = item.GetType().Name,
                        Type = item.GetType(),
                        IconType = GetRandomIconType(),
                        Items = new(),
                        Instance = (DependencyObject)item,
                        IsFolderExpanded = true
                    };
                    Controls.Add(anatomyItem);
                }
            }

            Controls[0].IsFolderExpanded = true;
            Controls[0].IsFolderSelected = true;
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
            Instance = item.Instance;
        }
    }
}
