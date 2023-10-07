using System.Windows;
using System.Windows.Controls;

namespace AnatomyAnalyzer.UI.Units
{
    public class DetailListItem : ListBoxItem
    {
        static DetailListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DetailListItem), new FrameworkPropertyMetadata(typeof(DetailListItem)));
        }
    }
}
