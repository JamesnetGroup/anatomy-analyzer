using System.Windows;
using System.Windows.Controls;

namespace AnatomyAnalyzer.UI.Units
{
    public class ControlTreeItem2 : TreeViewItem
    {
        static ControlTreeItem2()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ControlTreeItem2), new FrameworkPropertyMetadata(typeof(ControlTreeItem2)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new ControlTreeItem2();
        }
    }
}
