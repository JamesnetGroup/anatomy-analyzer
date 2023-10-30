using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Anatomy.Forms.UI.Views
{
    public class AnatomyWindow : DarkThemeWindow
    {
        static AnatomyWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AnatomyWindow), new FrameworkPropertyMetadata(typeof(AnatomyWindow)));
        }
    }
}
