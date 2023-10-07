using AnatomyAnalyzer.Local.Models;

namespace AnatomyAnalyzer.Local.Helpers
{
    public class AnatomyService2
    {
        public event EventHandler<AnatomyChangedEventArgs> AnatomyControlChanged;

        internal void Add(AnatomyItemCollection items)
        {
            var args = new AnatomyChangedEventArgs();
            args.Controls = items;
            AnatomyControlChanged.Invoke(this, args);
        }
    }
}
