using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace NestedListViewSample
{
    public class MultiplyConverter : IValueConverter
    {
        // Returns count * factor
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var count = 0d;
            if (value is int i) count = i;
            else if (value is double d) count = d;

            var factor = 0d;
            if (parameter is double pd) factor = pd;
            else if (parameter is string ps && double.TryParse(ps, NumberStyles.Any, CultureInfo.InvariantCulture, out var parsed))
                factor = parsed;

            return count * factor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            throw new NotSupportedException();
    }
}