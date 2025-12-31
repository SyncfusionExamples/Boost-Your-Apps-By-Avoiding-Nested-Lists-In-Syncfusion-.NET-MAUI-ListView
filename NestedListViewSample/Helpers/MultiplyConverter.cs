using System.Globalization;

namespace NestedListViewSample
{
    /// <summary>
    /// Multiplies the input value (count) by a factor passed via the converter parameter.
    /// Accepts count as int or double, and factor as double or parsable string (InvariantCulture).
    /// </summary>
    public class MultiplyConverter : IValueConverter
    {
        /// <summary>
        /// Converts a count to a size by multiplying with a factor.
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var count = 0d;
            if (value is int i)
            {
                count = i;
            }
            else if (value is double d)
            {
                count = d;
            }

            var factor = 0d;
            if (parameter is double pd)
            {
                factor = pd;
            }
            else if (parameter is string ps && double.TryParse(ps, NumberStyles.Any, CultureInfo.InvariantCulture, out var parsed))
            {
                factor = parsed;
            }

            return count * factor;
        }

        /// <summary>
        /// Not supported. Reverse conversion is not implemented.
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            throw new NotSupportedException();
    }
}