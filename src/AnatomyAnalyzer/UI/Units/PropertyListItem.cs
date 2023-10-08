using System.Windows;
using System.Windows.Controls;

namespace AnatomyAnalyzer.UI.Units
{
    public class PropertyListItem : ListBoxItem
    {
        static PropertyListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PropertyListItem), new FrameworkPropertyMetadata(typeof(PropertyListItem)));
        }
    }
}
