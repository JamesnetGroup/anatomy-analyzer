using System.Windows;
using System.Windows.Controls;

namespace AnatomyAnalyzer.UI.Units
{
    public class PropertyListView : ListBox
    {
        static PropertyListView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PropertyListView), new FrameworkPropertyMetadata(typeof(PropertyListView)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new PropertyListItem();
        }
    }
}
