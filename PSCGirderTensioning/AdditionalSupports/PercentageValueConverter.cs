using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PSCGirderTensioning.AdditionalSupports
{
    public class PercentageValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is string text && double.TryParse(text, out double number))
            {
                return $"{number / 100:P}";
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is string text && double.TryParse(text.Replace("%", ""), out double number))
            {
                return $"{number * 100}";
            }

            return value;
        }
    }
}
