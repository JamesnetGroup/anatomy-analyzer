using System.Windows;
using System.Windows.Controls.Primitives;

namespace AnatomyAnalyzer.UI.Units
{
    public class ExpandButton2 : ToggleButton
    {
        static ExpandButton2()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExpandButton2), new FrameworkPropertyMetadata(typeof(ExpandButton2)));
        }
    }
}
