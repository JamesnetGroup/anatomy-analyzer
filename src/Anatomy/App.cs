using Anatomy.Extensions;
using Anatomy.Forms.UI.Views;
using Anatomy.Support.Local.Helpers;
using Anatomy.Support.Local.Models;
using Jamesnet.Wpf.Controls;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using ThemeSwitch.UI.Units;
using XamlDesign.Wpf.UI.Units;
namespace Anatomy
{
    internal class App : JamesApplication
    {
        private AnatomyItemCollection _items;
        private AnatomyWindow _window;

        protected override Window CreateShell()
        {
            _window = new AnatomyWindow();

            return _window;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            _items = new();
            RegisterControls(_items);

            var service = GetService<AnatomyService>();

            service.Add(_items);
        }

        protected virtual void RegisterControls(AnatomyItemCollection items)
        {
            items.Add(new Button().InitSampleData(Theme.Black));
            items.Add(new Slider().InitSampleData(Theme.Black));
            items.Add(new TabControl().InitSampleData(Theme.Black));
            items.Add(new ListBox().InitSampleData(Theme.Black));
            items.Add(new ThemeSwitch.UI.Units.ThemeSwitch().InitSampleData(Theme.Black));
            items.Add(new FilledButton().InitSampleData(Theme.Black));
            items.Add(new BorderedButton().InitSampleData(Theme.Black));
            items.Add(new DateRangeSelector());
            items.Add(new IconCheckBox().InitSampleData(Theme.Black));
            items.Add(new ToggleSwitch().InitSampleData(Theme.Black));
            items.Add(new UnderlineMenuBox().InitSampleData(Theme.Black));
        }
    }
}
