using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Anatomy.Analysis.UI.Views
{
    public class AnalysisContent : JamesContent
    {
        static AnalysisContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AnalysisContent), new FrameworkPropertyMetadata(typeof(AnalysisContent)));
        }
    }
}
