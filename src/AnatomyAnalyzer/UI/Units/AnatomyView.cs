using System.Windows;
using System.Windows.Controls;

namespace AnatomyAnalyzer.UI.Units
{
    public class AnatomyView : ContentControl
    {
        static AnatomyView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AnatomyView), new FrameworkPropertyMetadata(typeof(AnatomyView)));
        }
    }
}
