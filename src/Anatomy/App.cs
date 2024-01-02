using Anatomy.Extensions;
using Anatomy.Forms.UI.Views;
using Anatomy.Support.Local.Helpers;
using Anatomy.Support.Local.Models;
using Anatomy.Support.UI.Units;
using DemoApp.Support.UI.Units;
using Jamesnet.Wpf.Controls;
using NavigationBar;
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
            var bar =new MagicBar();
            bar.Items.Add(new ListBoxItem { Content ="Microsoft", Tag = IconType.Microsoft });
            bar.Items.Add(new ListBoxItem { Content = "Apple", Tag = IconType.Apple });
            bar.Items.Add(new ListBoxItem { Content = "Google", Tag = IconType.Google});
            bar.Items.Add(new ListBoxItem { Content = "Facebook", Tag = IconType.Facebook });
            bar.Items.Add(new ListBoxItem { Content = "Instagram", Tag = IconType.Instagram });


            items.Add(new Button().InitSampleData(Theme.Black));
            items.Add(new Slider().InitSampleData(Theme.Black));
            items.Add(new TabControl().InitSampleData(Theme.Black));
            items.Add(new ListBox().InitSampleData(Theme.Black));
            items.Add(new RiotSlider().InitSampleData(Theme.Black));
            items.Add(new ThemeSwitch.UI.Units.ThemeSwitch().InitSampleData(Theme.Black));
            items.Add(new FilledButton().InitSampleData(Theme.Black));
            items.Add(new BorderedButton().InitSampleData(Theme.Black));
            items.Add(new DateRangeSelector());
            items.Add(new IconCheckBox().InitSampleData(Theme.Black));
            items.Add(new ToggleSwitch().InitSampleData(Theme.Black));
            items.Add(new UnderlineMenuBox().InitSampleData(Theme.Black));
            items.Add(new PlayButton());
            items.Add(bar);
        }
    }
}
