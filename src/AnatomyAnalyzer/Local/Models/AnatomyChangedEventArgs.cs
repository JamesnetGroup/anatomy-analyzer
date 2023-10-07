namespace AnatomyAnalyzer.Local.Models
{
    public class AnatomyChangedEventArgs : EventArgs
    {
        public AnatomyItem Item { get; set; }
        public AnatomyItemCollection Controls { get; internal set; }
    }
}
