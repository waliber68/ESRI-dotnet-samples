using Microsoft.UI.Xaml.Data;
using System;

namespace ArcGIS.WinUI.Viewer.Converters
{
    public class BoolToFavoriteGlyphConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value is true ? "\xe2a8" : "\xe2a9";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
