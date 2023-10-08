using System.Windows;
using System.Windows.Controls;

namespace AnatomyAnalyzer.UI.Units
{
    public class DetailList : ListBox
    {
        static DetailList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DetailList), new FrameworkPropertyMetadata(typeof(DetailList)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new DetailListItem();
        }
    }
}
