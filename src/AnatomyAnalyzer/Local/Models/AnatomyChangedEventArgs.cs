namespace AnatomyAnalyzer.Local.Models
{
    public class AnatomyChangedEventArgs : EventArgs
    {
        public AnatomyItemCollection Controls { get; internal set; }
    }
}
