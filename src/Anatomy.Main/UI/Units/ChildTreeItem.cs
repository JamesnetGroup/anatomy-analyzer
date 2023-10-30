﻿using System.Windows;
using System.Windows.Controls;

namespace Anatomy.Main.UI.Units
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
