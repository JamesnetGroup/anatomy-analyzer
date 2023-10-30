﻿using System.Windows;
using System.Windows.Controls;

namespace Anatomy.Main.UI.Units
{
    public class LanguageListBox : ListBox
    {
        static LanguageListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LanguageListBox), new FrameworkPropertyMetadata(typeof(LanguageListBox)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new LanguageListBoxItem();
        }
    }
}
