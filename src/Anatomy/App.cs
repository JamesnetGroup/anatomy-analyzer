using Anatomy.Forms.UI.Views;
using Anatomy.Support.Local.Helpers;
using Anatomy.Support.Local.Models;
using Jamesnet.Wpf.Controls;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

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

        public App()
        {
            //ResourceDictionary myResourceDictionary = new ResourceDictionary();
            //myResourceDictionary.Source = new Uri("/Anatomy.Support;component/Themes/Default.xaml", UriKind.RelativeOrAbsolute);
            //this.Resources.MergedDictionaries.Add(myResourceDictionary);
            //AddDefaultThemeResource();
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
            items.Add<Button>();
            items.Add<Slider>();
            items.Add<ComboBox>();
            items.Add<DataGrid>();
        }
        private void AddDefaultThemeResource()
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            AssemblyName[] referencedAssemblies = executingAssembly.GetReferencedAssemblies();
            foreach (AssemblyName assemblyName in referencedAssemblies)
            {
                try
                {
                    var resourceName = assemblyName.Name + ";component/Themes/Default.xaml";
                    var resourceUri = new Uri("/" + resourceName, UriKind.RelativeOrAbsolute);

                    ResourceDictionary resourceDictionary = new ResourceDictionary
                    {
                        Source = resourceUri
                    };

                    this.Resources.MergedDictionaries.Add(resourceDictionary);
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Could not load Themes/Default.xaml from {assemblyName.Name}: {ex.Message}");
                }
            }

            Console.WriteLine("Error: Could not find Themes/Default.xaml resource in any referenced assembly.");
        }
    }
}
