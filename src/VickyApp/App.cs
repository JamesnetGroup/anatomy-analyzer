using AnatomyAnalyzer.Controls;
using AnatomyAnalyzer.Local.Models;
using System.Windows;
using System.Windows.Controls;

namespace VickyApp
{
    internal class App : AnatomyApplication
    {
        protected override void RegisterControls(AnatomyItemCollection items)
        {
            base.RegisterControls(items);

            items.Add<Button>();
            items.Add<Slider>();
            items.Add<ComboBox>();
            items.Add<DataGrid>();
        }

        public App()
        {
            ResourceDictionary myResourceDictionary = new ResourceDictionary();
            myResourceDictionary.Source = new Uri("/VickyApp;component/Themes/Default.xaml", UriKind.RelativeOrAbsolute);
            this.Resources.MergedDictionaries.Add(myResourceDictionary);
        }
    }
}
