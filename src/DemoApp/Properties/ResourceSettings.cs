using Jamesnet.Wpf.Global.Composition;

namespace DemoApp.Properties
{
    internal class ResourceSettings : ResourceInitializer
    {
        protected override string GetDefaultLanguage()
        {
            return "USA";
        }

        protected override string GetDefaultTheme()
        {
            return "Black";
        }

        protected override string GetLanguageResource()
        {
            return "DemoApp.Resources.Language.yml";
        }

        protected override string GetThemeResource()
        {
            return "DemoApp.Resources.Theme.yml";
        }
    }
}
