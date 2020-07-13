using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Chapter6_5
{
    class HumanConverter:IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var human = new Human {Name = (string) value};
            return human;
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((Human) value)?.Name;
        }
    }

    internal class Human
    {
        public string Name { get; set; }
    }
}
