using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace CSharpSample02
{
    public class ColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            byte R = (byte)(double)(values[0]);
            byte G = (byte)(double)(values[1]);
            byte B = (byte)(double)(values[2]);

            return Color.FromRgb(R, G, B);
        }

        //-----------------------------------------------------------------------------------------------
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }
    } // end of ColorConverter class
}
