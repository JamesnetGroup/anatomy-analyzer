using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace AnatomyAnalyzer.Local.Converters
{
    public class UniformConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int count = int.Parse(value.ToString());

            count = count < 9 ? 4 : 8;

            return count;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
