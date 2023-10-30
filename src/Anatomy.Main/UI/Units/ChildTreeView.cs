using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Anatomy.Main.UI.Units
{
    internal class ChildTreeView : TreeView
    {
        static ChildTreeView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChildTreeView), new FrameworkPropertyMetadata(typeof(ChildTreeView)));
        }

        public static readonly DependencyProperty SelectionCommandProperty = DependencyProperty.Register("SelectionCommand", typeof(ICommand), typeof(ChildTreeView));

        public ICommand SelectionCommand
        {
            get => (ICommand)GetValue(SelectionCommandProperty);
            set => SetValue(SelectionCommandProperty, value);
        }


        public ChildTreeView()
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
            return new ChildTreeItem();
        }
    }
}
