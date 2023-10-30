namespace Anatomy.Support.Local.Models
{
    public class AnatomyEventArgs : EventArgs
    {
        public AnatomyItem Item { get; set; }
        public AnatomyItemCollection Controls { get; internal set; }
    }
}
