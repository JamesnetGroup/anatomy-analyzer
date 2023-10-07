using AnatomyAnalyzer.Controls;
using AnatomyAnalyzer.Local.Models;
using DemoApp.Support.UI.Units;
using System.Windows.Controls;

namespace DemoApp
{
    internal class App : AnatomyApplication
    {
        protected override void RegisterControls(AnatomyItemCollection items)
        {
            items.Add<PlayButton>();
            items.Add<Button>();
            items.Add<Slider>();
            items.Add<ComboBox>();
        }
    }
}
