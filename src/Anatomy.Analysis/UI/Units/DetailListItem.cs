using System.Windows;
using System.Windows.Controls;

namespace Anatomy.Analysis.UI.Units
{
    public class DetailListItem : ListBoxItem
    {
        static DetailListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DetailListItem), new FrameworkPropertyMetadata(typeof(DetailListItem)));
        }
    }
}
