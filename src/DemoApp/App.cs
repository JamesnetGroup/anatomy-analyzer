using AnatomyAnalyzer.Controls;
using AnatomyAnalyzer.Local.Models;
using DemoApp.Extensions;
using DemoApp.Support.UI.Units;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace DemoApp
{
    internal class App : AnatomyApplication
    {
        protected override void RegisterControls(AnatomyItemCollection items)
        {
            items.Add<PlayButton>();
            items.Add(new Button().InitSampleData(Theme.Light));
            items.Add(new Slider().InitSampleData(Theme.Light));
            items.Add(new ComboBox().InitSampleData(Theme.Light));
            items.Add(new CheckBox().InitSampleData(Theme.Black));
            items.Add(new RadioButton().InitSampleData(Theme.Black));
            items.Add(new ToggleButton().InitSampleData(Theme.Light));
            items.Add(new ListBox().InitSampleData(Theme.Light));
            items.Add(new Expander().InitSampleData(Theme.Black));
            items.Add(new GroupBox().InitSampleData(Theme.Black));
            items.Add(new TabControl().InitSampleData(Theme.Light));
            items.Add(new DataGrid().InitSampleData(Theme.Light));
        }
    }
}
