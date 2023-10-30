using System.Windows;
using XamlDesign.Wpf.UI.Units;

namespace AnatomyAnalyzer.UI.Units
{
    public class MainMenuBox : UnderlineMenuBox
    {
        static MainMenuBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainMenuBox), new FrameworkPropertyMetadata(typeof(MainMenuBox)));
        }
    }
}
