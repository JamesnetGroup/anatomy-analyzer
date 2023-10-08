using System.Windows;

namespace AnatomyAnalyzer.Local.Models
{
    public class DetailInfo
    {
        public string Name { get; set; }
        public object Content { get; set; }
        public FrameworkElement Instance { get; internal set; }
    }
}
