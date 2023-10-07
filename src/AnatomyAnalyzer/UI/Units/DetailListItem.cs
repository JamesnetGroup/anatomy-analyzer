using System.Windows;
using System.Windows.Controls;

namespace AnatomyAnalyzer.UI.Units
{
    public class DetailListItem2 : ListBoxItem
    {
        static DetailListItem2()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DetailListItem2), new FrameworkPropertyMetadata(typeof(DetailListItem2)));
        }
    }
}
