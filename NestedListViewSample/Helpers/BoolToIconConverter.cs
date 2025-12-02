using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace NestedListViewSample
{
    /// <summary>
    /// Converts a boolean expanded state to a glyph string for an icon font.
    /// </summary>
    public class BoolToIconConverter  : IValueConverter
    {
        /// <summary>
        /// Converts a boolean value to an icon glyph string.
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var expanded = value is bool b && b;
            return expanded ? "\ue705" : "\ue708";
        }

        /// <summary>
        /// Not supported. Conversion from glyph back to boolean is not implemented.
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}