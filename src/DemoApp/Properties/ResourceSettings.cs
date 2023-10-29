using Jamesnet.Wpf.Global.Composition;

namespace DemoApp.Properties
{
    internal class ResourceSettings : BaseResourceInitializer
    {
        protected override string DetermineDefaultLocale() => "USA";
        protected override string DetermineDefaultThemeName() => "Black";
        protected override string FetchLocalePath() => "DemoApp.Resources.Language.yml";
        protected override string FetchThemePath() => "DemoApp.Resources.Theme.yml";
    }
}
