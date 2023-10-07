using System.Windows;
using System.Windows.Controls;

namespace AnatomyAnalyzer.UI.Units
{
    public class ChildTreeItem : TreeViewItem
    {
        static ChildTreeItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChildTreeItem), new FrameworkPropertyMetadata(typeof(ChildTreeItem)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new ChildTreeItem();
        }
    }
}
