using Jamesnet.Wpf.Global.Composition;

namespace Anatomy.Properties
{
    internal class BaseResource : BaseResourceInitializer
    {
        protected override string DetermineDefaultLocale() => "USA";
        protected override string DetermineDefaultThemeName() => "Black";
        protected override string FetchLocalePath() => "Anatomy.Themes.Language.yml";
        protected override string FetchThemePath() => "Anatomy.Themes.Theme.yml";
    }
}
