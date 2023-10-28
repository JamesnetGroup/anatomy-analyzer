using Jamesnet.Wpf.Global.Composition;

namespace VickyApp.Properties
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
            return "VickyApp.Themes.Language.yml";
        }

        protected override string GetThemeResource()
        {
            return "VickyApp.Themes.Theme.yml";
        }
    }
}
