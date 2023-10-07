using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AnatomyAnalyzer.UI.Units
{
    internal class ControlTreeView2 : TreeView
    {
        static ControlTreeView2()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ControlTreeView2), new FrameworkPropertyMetadata(typeof(ControlTreeView2)));
        }

        public static readonly DependencyProperty SelectionCommandProperty = DependencyProperty.Register("SelectionCommand", typeof(ICommand), typeof(ControlTreeView2));

        public ICommand SelectionCommand
        {
            get => (ICommand)GetValue(SelectionCommandProperty);
            set => SetValue(SelectionCommandProperty, value);
        }


        public ControlTreeView2()
        {
            SelectedItemChanged += TreeView_SelectedItemChanged;
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (SelectedItem is not null)
            {
                SelectionCommand?.Execute(SelectedItem);
            }
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new ControlTreeItem2();
        }
    }
}
