using Jamesnet.Wpf.Global.Composition;

namespace VickyApp.Properties
{
    internal class ResourceSettings : BaseResourceInitializer
    {
        protected override string DetermineDefaultLocale() => "USA";
        protected override string DetermineDefaultThemeName() => "Black";
        protected override string FetchLocalePath() => "VickyApp.Themes.Language.yml";
        protected override string FetchThemePath() => "VickyApp.Themes.Theme.yml";
    }
}
