using System.Windows;
using System.Windows.Controls.Primitives;

namespace Anatomy.Support.UI.Units
{
    public class ExpandButton : ToggleButton
    {
        static ExpandButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExpandButton), new FrameworkPropertyMetadata(typeof(ExpandButton)));
        }
    }
}
