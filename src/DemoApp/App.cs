using AnatomyAnalyzer.Controls;
using AnatomyAnalyzer.Local.Models;
using DemoApp.Extensions;
using DemoApp.Support.UI.Units;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using XamlDesign.Wpf.UI.Units;

namespace DemoApp
{
    internal class App : AnatomyApplication
    {
        protected override void RegisterControls(AnatomyItemCollection items)
        {
            RangeSlider rangeSlider = new();
            rangeSlider.LeftValue = 20;
            rangeSlider.RightValue= 60;
            rangeSlider.Maximum = 100;
            rangeSlider.Width = 200;

            PropertyList propList = new();
            propList.TargetObject = this;

            items.Add<PlayButton>();
            items.Add(new ToggleSwitch().InitSampleData(Theme.Black));
            items.Add(new IconCheckBox().InitSampleData(Theme.Black));
            items.Add(new RangeCalendar());
            items.Add(rangeSlider);
            items.Add(propList);
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
