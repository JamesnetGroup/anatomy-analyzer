using System.Windows;
using System.Windows.Controls;

namespace Anatomy.Main.UI.Units
{
    public class LanguageListBoxItem : ListBoxItem
    {
        static LanguageListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LanguageListBoxItem), new FrameworkPropertyMetadata(typeof(LanguageListBoxItem)));
        }
    }
}
