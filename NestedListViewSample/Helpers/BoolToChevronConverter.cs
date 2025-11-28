using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace NestedListViewSample
{
    public class BoolToChevronConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var expanded = value is bool b && b;
            return expanded ? "\ue705" : "\ue708";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}