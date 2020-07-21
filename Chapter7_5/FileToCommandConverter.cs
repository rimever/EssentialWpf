using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Data;

namespace Chapter7_5
{
    public class FileToCommandConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var extension = (value as FileInfo)?.Extension.ToLowerInvariant();
            if (extension == ".txt")
            {
                return MainWindow.OpenCommand;
            }

            return MainWindow.BlockedCommand;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
