using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnatomyAnalyzer.UI.Units
{
    public class DetailList2 : ListBox
    {
        static DetailList2()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DetailList2), new FrameworkPropertyMetadata(typeof(DetailList2)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new DetailListItem2();
        }
    }
}
