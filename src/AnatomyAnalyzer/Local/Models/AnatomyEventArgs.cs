namespace AnatomyAnalyzer.Local.Models
{
    public class AnatomyEventArgs : EventArgs
    {
        public AnatomyItem Item { get; set; }
        public AnatomyItemCollection Controls { get; internal set; }
    }
}
