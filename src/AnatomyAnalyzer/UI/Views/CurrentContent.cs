using Jamesnet.Wpf.Controls;
using System.Windows;

namespace AnatomyAnalyzer.UI.Views
{
    public class CurrentContent : JamesContent
    {
        static CurrentContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CurrentContent), new FrameworkPropertyMetadata(typeof(CurrentContent)));
        }
    }
}
