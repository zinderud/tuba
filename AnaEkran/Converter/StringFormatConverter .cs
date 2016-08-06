using System;
using System.Windows.Data;

namespace AnaEkran.Converter
{
    public class StringFormatConverter : IValueConverter
    {
      
   

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //Check input params
            if (parameter == null || value == null)
                return value;

            return string.Format((string)parameter, value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}